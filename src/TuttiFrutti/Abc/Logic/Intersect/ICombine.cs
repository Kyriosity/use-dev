namespace Abc.Logic.Intersect;

public interface ICombine<T>
{

    T Join(T op1, T op2);
}

public interface IBoolCombine : ICombine<bool>;

public interface IDisjuct : IBoolCombine
{
    new bool Join(bool op1, bool op2) => op1 || op2;
}
