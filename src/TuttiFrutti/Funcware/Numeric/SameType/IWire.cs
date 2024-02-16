namespace Funcware.Numeric.SameType;
public interface IWire<in M> : IWire
{
    Func<N, N>? For<N>(M from, M to) where N : INumber<N>;
}
