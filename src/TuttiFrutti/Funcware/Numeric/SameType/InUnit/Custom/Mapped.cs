namespace Funcware.Numeric.SameType.InUnit.Custom;
public abstract class FuncStore<U> : IWire<U> where U : Enum // ToDo: ABSTRACT ?
{
    public Func<N, N>? For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        if (from.Equals(to))
            return x => x;

        var available = FuncsBag<N>();

        return available.TryGetValue((from, to), out var func) ? func : null;
    }

    protected virtual IDictionary<(U from, U to), Func<N, N>> FuncsBag<N>()
        where N : INumber<N> => new Dictionary<(U from, U to), Func<N, N>>();
}

// WHERE CustomeProvider : IFuncStore<T>

public class MappedProvide<U, FStore> : IWire<U> where U : Enum where FStore : IWire<U>
{
    //IRouter

    public Func<N, N>? For<N>(U from, U to) where N : INumber<N> {
        throw new NotImplementedException();
    }
}
