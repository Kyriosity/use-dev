using Abc.Ext.DataOps;
using Meas.Data.Setup.Attributes;
using Meas.Data.Setup.Formats;
using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Proc;
static class Row
{
    internal static IEnumerable<object[]> ByPair<N, TUnit>(IEnumerable<ISubject<N, TUnit>> items, string className = "") where N : INumber<N> {

        var result = items.SelectMany(item => Combi.Pair(item.Entries)
            .Select(x => new object[] { x[0], x[1], Delta(item.Attributes), item.Name, item.Cat, className }));

        return result;
    }

    private static double? Delta(IDictionary<string, object> attributes) =>
        attributes.TryGetValue(nameof(PrecisionAttribute), out var delta) ? delta as double? : null;

}
