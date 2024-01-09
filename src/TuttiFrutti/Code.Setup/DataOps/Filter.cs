namespace Abc.Ext.DataOps;
public static class Filter
{
    public static IEnumerable<T> ByCast<T>(IEnumerable<object> source, out IEnumerable<object> unmatched) where T : class {

        var casted = source.Select((x, i) => (val: x as T, index: i)).Where(g => g.val is not null)
            .ToList();

        var indeces = casted.Select(x => x.index).ToList();
        unmatched = source.Where((_, i) => !indeces.Contains(i));

        return casted.Select(x => x.val);
    }
}
