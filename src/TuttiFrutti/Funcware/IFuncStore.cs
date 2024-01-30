namespace Funcware;

public interface IFuncStore { }
public interface IFuncStore<M> : IFuncStore
{
    Func<T, T> For<T>(M from, M to);
}
