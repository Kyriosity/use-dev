namespace Funcware.Constraint;
public interface IWire<in M, in C> : IWire
{
    Func<T, T> For<T>(M from, M to) where T : C;
}
