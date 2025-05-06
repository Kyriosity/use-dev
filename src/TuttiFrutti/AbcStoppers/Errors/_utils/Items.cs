namespace AbcStoppers.Errors.Utils;
internal static class Items
{
    public static (T val, string tag)[] Tag<T>(IEnumerable<T> args, string itemsSetter) =>
        [.. args.Select((x, i) => (x, $"{itemsSetter}[{i}]"))];
}