namespace Abc.Logic.Fuse;

public interface IBool : IBase<bool>;

public interface IDisjunct : IBool
{
    new bool Join(bool left, bool right) => left | right;
}

public interface IConjunct : IBool
{
    new bool Join(bool left, bool right) => left & right;
}

public interface IExclude : IBool
{
    new bool Join(bool left, bool right) => left ^ right;
}
