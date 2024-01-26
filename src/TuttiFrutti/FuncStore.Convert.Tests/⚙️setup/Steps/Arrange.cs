using FuncStore.Conversion.Tests._️setup.Proc;
using FuncStore.Conversion.Tests.Setup.Proc;
using Meas.Data.Setup.Extensions;
using Meas.Data.Setup.Metadata;
using System.Reflection;
using RawData = (string name, object value, (bool set, double? delta) precision);

namespace FuncStore.Conversion.Tests.Setup.Steps;

[TestFixture]
public abstract class Arrange<TUnit> where TUnit : Enum, IConvertible
{
    protected virtual double DefaultDelta { get; private set; } = 0;

    [OneTimeSetUp]
    public void Init() {
        if (PrecisionAttribute.From<double>(this.GetType(), out var delta))
            DefaultDelta = (double)delta;
    }

    static IEnumerable<object[]> CompileTestSource(Type[] catalogs, string[] args) {
        if (args is not null && args.Any())
            Console.WriteLine($"arguments supplied but not supported\n(\"{string.Join("\", \"", args)}\")");

        return catalogs.Where(x => !NotForTestAttribute.From(x).Any())
            .SelectMany(MergeTestSources);
    }

    static IEnumerable<object[]> MergeTestSources(Type @class) {
        double? classDelta = PrecisionAttribute.From<double>(@class, out var delta) ? delta : null;
        // ToDo: propagate/store as default !

        var allFields = @class.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).ToList();
        var fields = allFields.Where(x => !NotForTestAttribute.From(x).Any());
        var @object = Activator.CreateInstance(@class);
        var attributedValues = fields.Select(x => (name: x.Name, value: x.GetValue(@object),
            precision: (set: PrecisionAttribute.From<double>(x, out var delta), delta: (double?)delta)));

        var datasources = new List<IEnumerable<object[]>> { };

        Parallel.ForEach(Retrievers, func => datasources.Add(func(attributedValues)));

        return datasources.SelectMany(x => x).ToArray();
    }

    private static IEnumerable<object[]> FromRecs(IEnumerable<RawData> source) =>
        Units<TUnit>.SwapParseable(TestSource.FromRecords(source), DataRow.UnitsIndeces);

    private static IEnumerable<object[]> FromDirs(IEnumerable<RawData> source) {
        var itemized = TestSource.FromMeasurements(source);
        var unitsAssigned = Units<TUnit>.SwapParseable(itemized);
        var expanded = DataRow.Normalize(unitsAssigned.Where(x => 1 < x.Entries.Count()));

        return expanded;
    }

    private static IEnumerable<Func<IEnumerable<RawData>, IEnumerable<object[]>>> Retrievers => [FromRecs, FromDirs];
}