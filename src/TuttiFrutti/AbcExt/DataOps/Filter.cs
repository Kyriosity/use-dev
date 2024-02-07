namespace AbcExt.DataOps;
public static class Filter
{
    public static IEnumerable<T> ByCast<T>(IEnumerable<object> source, out IEnumerable<object> unmatched) where T : class {

        var casted = ByCast<T>(source, out int[] indeces);

        unmatched = source.Where((_, i) => !indeces.Contains(i));

        return casted;
    }

    public static IEnumerable<T> ByCast<T>(IEnumerable<object> source, out int[] matchIndeces) where T : class {
        var casted = source.Select((x, i) => (val: x as T, index: i)).Where(g => g.val is not null)
            .ToList();

        matchIndeces = casted.Select(x => x.index).ToArray();

        return casted.Select(x => x.val);
    }
}
