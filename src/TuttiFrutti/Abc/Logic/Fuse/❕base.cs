namespace Abc.Logic.Fuse;

public interface IBase<T>
{
    T Join(Func<T> left, Func<T> right) => throw new NotImplementedException();
}