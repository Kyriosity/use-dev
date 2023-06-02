namespace Abc;

public interface IItem { }

public interface IItem<T> : IItem
{
    T? Item { get; }
}

public interface IItemed<T> : IItem<T>
{
    new T? Item { get; init; }
}

public interface IMutableItem<T> : IItem<T>
{
    new T? Item { get; set; }
}