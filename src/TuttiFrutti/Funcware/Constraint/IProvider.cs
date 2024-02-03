namespace Funcware.Constraint;
public interface IProvider<M, C> : IProvider
{
    Func<T, T> For<T>(M from, M to) where T : C;
}
