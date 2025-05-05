namespace Abc.Logic.Fuse.Lazy;

public interface IBool : IBase<bool>;

public interface IDisjunct : IBool
{
    new bool Join(bool left, Func<bool> right) => left || right();
}

public interface IConjunct : IBool
{
    new bool Join(bool left, Func<bool> right) => left && right();
}