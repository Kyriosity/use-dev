namespace Funcware;

public interface IProvider { }
public interface IProvider<M> : IProvider
{
    Func<T, TResult> For<T, TResult>(M from, M to);
}
