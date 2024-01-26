using Meas.Data.Setup.Formats;
using Meas.Units.Utils;
using System.Numerics;

namespace FuncStore.Conversion.Tests._️setup.Proc;
static class Units<TUnit> where TUnit : Enum
{
    internal static IEnumerable<ISubject<N, TUnit>> SwapParseable<N>(IEnumerable<ISubject<N, string>> items) where N : INumber<N> {
        var unitized = items.Select(x => new ISubject<N, TUnit> {
            Cat = x.Cat, Name = x.Name, Delta = x.Delta, Entries = SwapParseable(x.Entries)
        }).ToList();

        return unitized;
    }

    internal static object[][] SwapParseable(IEnumerable<object[]> source, int[] indeces) {
        var unitCasted = source.Select(x => (success: TryCast(x, indeces, out var cast), result: cast.ToArray()))
            .Where(x => x.success).Select(x => x.result);
        return unitCasted.ToArray();
    }

    internal static bool TryCast(object[] raw, int[] indeces, out IEnumerable<object> casted) {
        var units = indeces.Select(i => (success: Match.TryLoose(raw[i] as string, out TUnit? unit), result: unit, index: i))
            .ToArray();

        casted = raw.Select((x, index) => indeces.Contains(index) ? units.Single(u => u.index == index).result : x);

        return units.All(x => x.success);
    }

    private static IEnumerable<(N, TUnit)> SwapParseable<N>(IEnumerable<(N value, string unit)> source) where N : INumber<N> {
        var casted = source.Select(x => (value: x.value, success: Match.TryLoose(x.unit, out TUnit? match), unit: match));
        var unitized = casted.Where(x => x.success).Select(x => (value: x.value, unit: x.unit));

        return unitized;
    }
}
