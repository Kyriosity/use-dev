using System.Numerics;

namespace Funcware.Numeric;
public interface IProvider<M> : IProvider
{
    Func<T, TResult> For<T, TResult>(M from, M to) where T : INumber<T> where TResult : INumber<TResult>;
}
