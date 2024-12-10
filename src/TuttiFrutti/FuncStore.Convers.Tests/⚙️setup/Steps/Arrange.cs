using FuncStore.Convers.Tests.Setup.Proc;
using MeasData.Setup.Extensions;
using MeasData.Setup.Metadata;
using System.Reflection;
using RawData = (string name, object value, double? delta);

namespace FuncStore.Convers.Tests.Setup.Steps;

[TestFixture]
public abstract class Arrange<TUnit> where TUnit : Enum
{
    protected virtual double DefaultDelta { get; private set; } = 0;

    static ObjArrays CompileTestSource(IEnumerable<Type> catalogs, string[] _) =>
        catalogs.Where(x => !NotForTestAttribute.From(x).Any())
            .SelectMany(MergeTestSources);

    static ObjArrays MergeTestSources(Type @class) {
        double? commonDelta = PrecisionAttribute.From<double>(@class, out var delta) ? delta : null;

        var allFields = @class.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).ToList();
        var fields = allFields.Where(x => !NotForTestAttribute.From(x).Any());
        var @object = Activator.CreateInstance(@class);
        var attributedValues = fields.Select(x => (name: x.Name, value: x.GetValue(@object), delta: SelectPrecision(x, commonDelta)));

        var datasources = new List<ObjArrays> { };

        Parallel.ForEach(Retrievers, func => datasources.Add(func(attributedValues)));

        return datasources.SelectMany(x => x).ToArray();
    }

    private static double? SelectPrecision(MemberInfo member, double? fallback = null) =>
        PrecisionAttribute.From<double>(member, out var defined) ? defined : fallback;

    private static ObjArrays FromRecs(IEnumerable<RawData> source) =>
        Units<TUnit>.SwapParseable(TestSource.FromRecords(source), MeasDataRow.UnitsIndexes);

    private static ObjArrays FromDirs(IEnumerable<RawData> source) {
        var itemized = TestSource.FromMeasurements(source);
        var unitsAssigned = Units<TUnit>.SwapParseable(itemized);
        var expanded = MeasDataRow.Normalize(unitsAssigned
            .Where(x => 1 < x.Entries.Count()));

        return expanded;
    }

    private static IEnumerable<Func<IEnumerable<RawData>, ObjArrays>> Retrievers => [FromRecs, FromDirs];
}