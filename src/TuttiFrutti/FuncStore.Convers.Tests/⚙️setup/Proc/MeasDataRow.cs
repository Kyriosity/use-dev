using MeasData.Setup.Formats;

namespace FuncStore.Convers.Tests.Setup.Proc;
static class MeasDataRow
{
    internal static ObjArrays Normalize<N, TUnit>(IEnumerable<Subject<N, TUnit>> items) where N : INumber<N> =>
        items.SelectMany(item => CrossPair(item.Entries).Select(
            x => new object[] { x[0].val, x[0].unit, x[1].val, x[1].unit, item.Name, item.Cat, item.Delta }));

    internal static int[] UnitsIndexes => [1, 3];

    private static IEnumerable<T[]> CrossPair<T>(IEnumerable<T> entries) {
        var pairs = Combi.Pair(entries);

        var reversed = pairs.Select(pair => ((IEnumerable<T>)pair).Reverse().ToArray());
        return pairs.Concat(reversed);
    }
}
