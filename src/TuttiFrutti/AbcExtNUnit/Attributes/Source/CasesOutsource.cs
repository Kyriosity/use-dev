namespace AbcExtNUnit.Attributes.Source;

static class CasesOutsource
{
    public static object[]?[] YieldMultiple(object[] args) =>
        [.. args.TakeWhile(item => item is not null).Select(x => x as object[])];

    public static object[] YieldSingle(object item1, object item2, params object[] rest) =>
        [item1, item2, .. rest];
}
