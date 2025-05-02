namespace Abc.Logic.Fuse;

public interface IBool : IBase<bool>;

public interface IDisjunct : IBool
{
    new bool Join(Func<bool> left, Func<bool> right) => left() || right();
}

public interface IConjunct : IBool
{
    new bool Join(Func<bool> left, Func<bool> right) => left() && right();
}

public interface IExclude : IBool
{
    new bool Join(Func<bool> left, Func<bool> right) => left() ^ right();
}