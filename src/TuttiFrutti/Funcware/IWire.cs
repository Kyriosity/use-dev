namespace Funcware;

public interface IWire;

public interface IWire<in M> : IWire
{
    Func<T, TResult> For<T, TResult>(M from, M to);
}
