//namespace Funcware.Numeric.SameType.InUnit.FuncStore;

//// ToDesign: INHERIT FROM IRouter ???
//public class LinkedBag<U> : IProvider<U> where U : Enum
//{
//    // ToDesign: INJECT / DEPEND !
//    // router TYPE SPECIFIC !
//    private IRouter<U> _router = new AutoChainer<U> {
//        Linked = AutoChainer<U>.FromDirectPairs(FuncsBag<int>().Keys)
//    };

//    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
//        if (from.Equals(to))
//            return x => x;

//        var route = _router.For(from, to);
//        return route.Any() ? ChainFuncs<N>(route) : null;
//    }

//    private Func<T, T> ChainFuncs<T>(U[] nodes) {
//        // ToDelete: only for first tests! LINQ it!
//        var aaaa = FuncsBag<T>()[(nodes[0], nodes[1])];
//        var bbbb = FuncsBag<T>()[(nodes[1], nodes[2])];
//        return x => bbbb(aaaa(x));
//    }

//    protected virtual IDictionary<(U from, U to), Func<T, T>> FuncsBag<T>() {
//        throw new NotImplementedException();
//    }
//}
//public class AutoChainer<T> : IRouter<T> // 
//{
//    public static IDictionary<(T, T), T[]> FromDirectPairs(IEnumerable<(T from, T to)> pairs) {
//        return new Dictionary<(T, T), T[]>();
//    }

//    public required IDictionary<(T, T), T[]> Linked { get; init; } = new Dictionary<(T, T), T[]>();

//    public T[] For(T from, T to) {
//        if (Linked.TryGetValue((from, to), out var route))
//            return route;

//        Linked[(from, to)] = [];
//        return Linked[(from, to)];
//    }
//}

//public interface IRouter<T> // ToDo: move to structures and REPLACE WITH IEDGE.For ?
//{
//    // https://learn.microsoft.com/en-us/previous-versions/ms379574(v=vs.80)?redirectedfrom=MSDN#datastructures20_5_topic3
//    T[] For(T from, T to);
//}

//// ToDo: common For with FuncStore !!! IEdge ?

//public class Router<T> : IRouter<T>
//{
//    public IDictionary<(T, T), T[]> Links { get; init; } = new Dictionary<(T, T), T[]>();

//    public virtual T[] For(T from, T to) => Links.TryGetValue((from, to), out var chain) ? chain : Array.Empty<T>();
//}
