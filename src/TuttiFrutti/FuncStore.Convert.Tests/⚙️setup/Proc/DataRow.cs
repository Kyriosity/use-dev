using Abc.Ext.DataOps;
using Meas.Data.Setup.Formats;
using System.Numerics;

namespace FuncStore.Conversion.Tests.Setup.Proc;
static class DataRow
{
    internal static IEnumerable<object[]> Normalize<N, TUnit>(IEnumerable<ISubject<N, TUnit>> items) where N : INumber<N> =>
        items.SelectMany(item => CrossPair(item.Entries).Select(
            x => new object[] { x[0].val, x[0].unit, x[1].val, x[1].unit, item.Name, item.Cat, item.Delta }));

    internal static int[] UnitsIndeces => [1, 3];

    private static IEnumerable<T[]> CrossPair<T>(IEnumerable<T> entries) {
        var pairs = Combi.Pair(entries);
        var reversed = pairs.Select(x => x.Reverse().ToArray());
        return pairs.Concat(reversed);
    }
}
