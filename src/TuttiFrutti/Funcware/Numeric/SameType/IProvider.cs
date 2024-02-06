namespace Funcware.Numeric.SameType;
public interface IProvider<in M> : IProvider
{
    Func<N, N>? For<N>(M from, M to) where N : INumber<N>;
}
