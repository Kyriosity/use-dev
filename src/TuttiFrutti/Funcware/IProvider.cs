namespace Funcware;

public interface IProvider;
public interface IProvider<in M> : IProvider
{
    Func<T, TResult> For<T, TResult>(M from, M to);
}
