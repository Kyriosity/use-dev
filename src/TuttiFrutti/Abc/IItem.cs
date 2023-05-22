namespace Abc;

public interface IItem { }

public interface IItem<T> : IItem
{
    abstract T? Item { get; }
}

public interface IItemed<T> : IItem<T>
{
    new T? Item { get; init; }
}

public interface IItemSettable<T> : IItem<T>
{
    new T? Item { get; set; }
}