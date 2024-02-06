namespace Funcware.Numeric.SameType.InUnit.FuncStore;
public abstract class CustomProvider<U> : IProvider<U> where U : Enum
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
