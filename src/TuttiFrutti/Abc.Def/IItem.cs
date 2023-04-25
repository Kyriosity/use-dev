namespace Abc.Def;

public interface IItem { }

public interface IItemed<T> : IItem
{
    T? Item { get; }
}

public interface IItem<T> : IItemed<T>
{
    new T? Item { get; set; }
}