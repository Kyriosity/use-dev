namespace Funcware.Constraint;
public interface IFuncStore<M, C> : IFuncStore
{
    Func<T, T> For<T>(M from, M to) where T : C;
}
