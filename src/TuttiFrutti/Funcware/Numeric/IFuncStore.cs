using System.Numerics;

namespace Funcware.Numeric;
public interface IFuncStore<M> : IFuncStore
{
    Func<N, N> For<N>(M from, M to) where N : INumber<N>;
}
