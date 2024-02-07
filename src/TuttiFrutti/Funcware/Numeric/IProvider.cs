namespace Funcware.Numeric;
public interface IProvider<in M> : IProvider
{
    Func<T, TResult> For<T, TResult>(M from, M to) where T : INumber<T> where TResult : INumber<TResult>;
}
