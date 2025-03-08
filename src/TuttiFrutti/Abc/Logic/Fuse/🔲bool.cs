namespace Abc.Logic.Fuse;

public interface IBool : IBase<bool>;

public interface IDisjunct : IBool
{
    new bool Join(bool op1, bool op2) => op1 | op2;
}

public interface IConjunct : IBool
{
    new bool Join(bool op1, bool op2) => op1 & op2;
}

public interface IExclude : IBool
{
    new bool Join(bool op1, bool op2) => op1 ^ op2;
}
