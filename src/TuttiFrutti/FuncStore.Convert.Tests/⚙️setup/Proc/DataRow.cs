using Abc.Ext.DataOps;
using Meas.Data.Setup.Formats;
using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Proc;
static class DataRow
{
    internal static IEnumerable<object[]> ThroughPair<N, TUnit>(IEnumerable<ISubject<N, TUnit>> items) where N : INumber<N> =>
        items.SelectMany(item => Combi.Pair(item.Entries).Select(
            x => new object[] { x[0].val, x[0].unit, x[1].val, x[1].unit, item.Name, item.Cat, item.Delta }));

    internal static int[] UnitsIndeces => [1, 3];
}
