using Meas.Data.Setup.Formats;
using Meas.Units.Utils;
using System.Numerics;

namespace FuncStore.Convert.Tests._️setup.Proc;
static class Units<TUnit> where TUnit : Enum
{
    internal static IEnumerable<ISubject<N, TUnit>> SwapType<N>(IEnumerable<ISubject<N, string>> items) where N : INumber<N> {
        var unitized = items.Select(item => new ISubject<N, TUnit> {
            Cat = item.Cat, Name = item.Name, Attributes = item.Attributes,
            Entries = ConvertApplicable(item.Entries)
        });

        return unitized;
    }

    private static IEnumerable<(N, TUnit)> ConvertApplicable<N>(IEnumerable<(N, string)> items) where N : INumber<N> {

        var unitized = items.Select(x => (value: x.Item1, success: Match.TryLoose(x.Item2, out TUnit? match), unit: match));

        // ToDo: UNPARSED units ! (AS SEPARATE TEST ?)

        var unparsed = new List<string>(); // unitized.Where(x => !x.success).Select(;
        return unitized.Where(x => x.success).Select(x => (value: x.value, unit: x.unit));
    }
}
