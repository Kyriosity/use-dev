namespace Funcware.Numeric.SameType.InUnit.Ratio;

internal class Exponent<U> : Funcware.Numeric.SameType.InUnit.IProvider<U>
    where U : Enum
{
    public Func<N, N> For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        throw new NotImplementedException();
    }
}
