using AbcExt.Errors.Sys;

namespace AbcExt.DataOps;
public static class Combi
{
    public static IEnumerable<T[]> Pair<T>(IEnumerable<T> source) {
        var list = source.ToList();
        return from left in list.Select((x, index) => new { x, index })
               from right in list.Select((x, index) => new { x, index })
               where left.index < right.index
               select new T[] { left.x, right.x };
    }

    public static IEnumerable<T[]> Triple<T>(IEnumerable<T> _) => NotImplemented.Throw("on demand");
    // ToAdd: quadruple, quintuple, sextuple, septuple, octuple, ..., n‑tuple,
}
