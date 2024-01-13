using Abc.Ext.Errors.Sys;

namespace Abc.Ext.DataOps;
public static class Combi
{
    public static IEnumerable<T[]> Pair<T>(IEnumerable<T> data) =>
         from left in data.Select((x, index) => new { x, index })
         from right in data.Select((x, index) => new { x, index })
         where left.index < right.index
         select new T[] { left.x, right.x };

    public static IEnumerable<T[]> Triple<T>(IEnumerable<T> _) => NotImplemented.Throw("on demand");
    // ToDo: quadruple, quintuple, sextuple, septuple, octuple, ..., n‑tuple,
}
