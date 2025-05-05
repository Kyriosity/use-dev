namespace Abc.Logic.Fuse.Lazy;

public interface IBase<T>
{
    T Join(T left, Func<T> right) => throw new NotImplementedException();
}