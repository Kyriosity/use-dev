namespace Code.Setup.Validation;
public static partial class Guard
{
    //var duplicates = dims.GroupBy(x => x.Item2).Where(g => 1 < g.Count()).Select(y => y.Key).ToList();
    //    if (0 < duplicates.Count)
    //        Inconsistency.Throw($"{nameof(duplicates)}: `{string.Join("`, `", duplicates)}`");
}
