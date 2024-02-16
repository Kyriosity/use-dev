namespace Funcware.Numeric;
public interface IWire<in M> : IWire
{
    Func<T, TResult> For<T, TResult>(M from, M to) where T : INumber<T> where TResult : INumber<TResult>;
}
