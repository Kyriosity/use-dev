using System.Numerics;

namespace Funcware.Numeric.SameType;
public interface IProvider<M> : IProvider
{
    Func<N, N> For<N>(M from, M to) where N : INumber<N>;
}
