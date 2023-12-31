using FuncStore.Convert.Tests._️setup.Proc;
using Meas.Data.Formats;
using Meas.Data.Setup.Extensions;
using Meas.Units.Utils;
using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Steps;

[TestFixture]
public abstract class Arrange<TUnit> where TUnit : Enum, IConvertible
{
    static IEnumerable<object[]> MakeTestSource(Type[] catalogs, string[]? args) =>
        catalogs.SelectMany(@class => Declassify(@class));

    static IEnumerable<object[]> Declassify(Type @class) {
        var @object = Activator.CreateInstance(@class);

        var itemized = (@object as IDataSource)?.Itemize() ?? new List<ISubject<double, string>>();
        // ToDo: WARN IF NOT DATA SOURCE !
        var unitsAssigned = SwapUnitsType(itemized);
        var expanded = Row.ByPair(unitsAssigned.Where(x => 1 < x.Entries.Count()), @class.Name);

        return expanded;
    }

    private static IEnumerable<ISubject<N, TUnit>> SwapUnitsType<N>(IEnumerable<ISubject<N, string>> items) where N : INumber<N> {
        var unitized = items.Select(item => new ISubject<N, TUnit> {
            Cat = item.Cat, Name = item.Name, Attributes = item.Attributes,
            Entries = ConvertApplicable(item.Entries)
        });

        return unitized;
    }

    // ToDo: Class UNITS
    private static IEnumerable<(N, TUnit)> ConvertApplicable<N>(IEnumerable<(N, string)> items) where N : INumber<N> {

        var unitized = items.Select(x => (value: x.Item1, success: Match.TryLoose(x.Item2, out TUnit? match), unit: match));

        // ToDo: UNPARSED units ! (AS SEPARATE TEST ?)

        var unparsed = new List<string>(); // unitized.Where(x => !x.success).Select(;
        return unitized.Where(x => x.success).Select(x => (value: x.value, unit: x.unit));
    }
}