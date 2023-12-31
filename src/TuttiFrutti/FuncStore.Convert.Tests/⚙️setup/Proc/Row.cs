using Abc.Ext.DataOps;
using Meas.Data.Formats;
using System.Numerics;

namespace FuncStore.Convert.Tests._️setup.Proc;
static class Row
{
    internal static IEnumerable<object[]> ByPair<N, TUnit>(IEnumerable<ISubject<N, TUnit>> items, string className) where N : INumber<N> {

        var result = items.SelectMany(item => Combi.Pair(item.Entries)
            .Select(x => new object[] { x[0], x[1], item.Name, item.Cat, className }));

        return result;
    }
}
