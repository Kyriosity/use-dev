using FuncStore.Convert.Tests._️setup.Proc;
using FuncStore.Convert.Tests.Setup.Proc;
using Meas.Data.Setup.Attributes;
using Meas.Data.Setup.Extensions;
using System.Reflection;
using RawData = (string name, object value, (bool set, double? delta) precision);

namespace FuncStore.Convert.Tests.Setup.Steps;

[TestFixture]
public abstract class Arrange<TUnit> where TUnit : Enum, IConvertible
{
    protected virtual double DefaultDelta { get; private set; } = 0;

    [OneTimeSetUp]
    public void Init() {
        if (PrecisionAttribute.Find(this.GetType(), out var delta))
            DefaultDelta = (double)delta;
    }

    static IEnumerable<object[]> CompileTestSource(Type[] catalogs, string[] args) {
        if (args is not null && args.Any())
            Console.WriteLine($"arguments supplied but not supported\n(\"{string.Join("\", \"", args)}\")");

        return catalogs.Where(x => !NotForTestAttribute.Find(x, out var _))
            .SelectMany(MergeTestSources);
    }

    static IEnumerable<object[]> MergeTestSources(Type @class) {


        if (PrecisionAttribute.Find(@class, out var delta)) {
            // ToDo: propagate/store as default !
        }

        var allFields = @class.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).ToList();
        var fields = allFields.Where(x => !NotForTestAttribute.Find(x, out var _));
        var @object = Activator.CreateInstance(@class);
        var source = fields.Select(x => (name: x.Name, value: x.GetValue(@object), precision:
            (set: PrecisionAttribute.Find(x, out var delta), delta: delta)));

        var datasource = new object[][] { };

        Parallel.ForEach(Retrievers, func => {
            datasource = datasource.Concat(func(source)).ToArray();
        });

        return datasource;
    }

    private static IEnumerable<object[]> FromRecs(IEnumerable<RawData> source) =>
        Units<TUnit>.SwapApplicable(TestSource.FromRecords(source), DataRow.UnitsIndeces);

    private static IEnumerable<object[]> FromDirs(IEnumerable<RawData> source) {
        var itemized = TestSource.FromMeasurements(source);
        var unitsAssigned = Units<TUnit>.SwapApplicable(itemized);
        var expanded = DataRow.ThroughPair(unitsAssigned.Where(x => 1 < x.Entries.Count()));

        return expanded;
    }

    private static IEnumerable<Func<IEnumerable<RawData>, IEnumerable<object[]>>> Retrievers => [FromRecs, FromDirs];
}