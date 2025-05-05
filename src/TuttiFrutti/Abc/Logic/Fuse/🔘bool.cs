namespace Abc.Logic.Fuse;

public interface IBool : IBase<bool>;

public interface IExclude : IBool
{
    new bool Join(bool left, bool right) => left ^ right;
}