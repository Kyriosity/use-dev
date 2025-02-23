using AbcStuff.Test;

namespace AbcExtNUnit.Attributes.Source;

static class CasesOutsource
{
    public static IEnumerable<object[]> YieldMultiple(object[] args) =>
        [.. args.TakeWhile(item => item is not null).Select(x => x as object[])];

    public static IEnumerable<object> YieldSingle(object item1, object item2, params object[] rest) =>
        [item1, item2, .. rest];

    public static IEnumerable<object[]> PullYield(IEnumerable<Type> sources, object[] _) {

        var res = sources.SelectMany(PullFromType);
        return res;
    }


    private static IEnumerable<object[]> PullFromType(Type source) {
        var directives = source.GetInterfaces().Where(IsDataSource);

        var data = directives.SelectMany(dir => PullByMethod(dir, source));

        return data.Select(row => (object[])[source.Name, .. row]);
    }

    private static IEnumerable<object[]> PullByMethod(Type directive, Type source) {
        var method = directive.GetMethod(nameof(IDataSource.Pull));
        var data = (IEnumerable<object[]>)method.Invoke(null, [source]);

        return data;
    }

    private static bool IsDataSource(Type type) =>
        type.GetInterfaces().Any(x => _datasourceType == x);

    private static readonly Type _datasourceType = typeof(IDataSource);
}