namespace Funcware.Numeric.SameType.InUnit.FuncStore;

public class FuncStore<M> : IProvider<M> // ToDesign: INHERIT FROM IRouter ???
{
    // ToDesign: INJECT / DEPEND !
    // router TYPE SPECIFIC !
    private IRouter<M> _router = new OneWayNoneCyclic<M> {
        Linked = OneWayNoneCyclic<M>.FromDirectPairs(_funcs<int>().Keys)
    };

    public Func<T, T> For<T>(M from, M to) {
        if (from.Equals(to))
            return x => x;

        var route = _router.For(from, to);
        return route.Any() ? ChainFuncs<T>(route) : null;
    }

    private Func<T, T> ChainFuncs<T>(M[] nodes) {
        // ToDelete: only for first tests! LINQ it!
        var aaaa = _funcs<T>()[(nodes[0], nodes[1])];
        var bbbb = _funcs<T>()[(nodes[1], nodes[2])];
        return x => bbbb(aaaa(x));
    }

    protected virtual IDictionary<(M from, M to), Func<T, T>> _funcs<T>() {
        throw new NotImplementedException();
    }
}
public class AutoChainer<T> : IRouter<T> // 
{
    public static IDictionary<(T, T), T[]> FromDirectPairs(IEnumerable<(T from, T to)> pairs) {
        return new Dictionary<(T, T), T[]>();
    }

    public required IDictionary<(T, T), T[]> Linked { get; init; } = new Dictionary<(T, T), T[]>();

    public T[] For(T from, T to) {
        if (Linked.TryGetValue((from, to), out var route))
            return route;

        Linked[(from, to)] = [];
        return Linked[(from, to)];
    }
}

public interface IRouter<T> // ToDo: move to structures and REPLACE WITH IEDGE.For ?
{
    // https://learn.microsoft.com/en-us/previous-versions/ms379574(v=vs.80)?redirectedfrom=MSDN#datastructures20_5_topic3
    T[] For(T from, T to);
}

// ToDo: common For with FuncStore !!! IEdge ?

public class Router<T> : IRouter<T>
{
    public IDictionary<(T, T), T[]> Links { get; init; } = new Dictionary<(T, T), T[]>();

    public virtual T[] For(T from, T to) => Links.TryGetValue((from, to), out var chain) ? chain : Array.Empty<T>();
}
