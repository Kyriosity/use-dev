namespace Abc.Logic.Fuse;

public interface IBase<T>
{
    T Join(T op1, T op2);
}

