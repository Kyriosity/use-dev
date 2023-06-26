namespace Abc.Item;

public interface IDistinct { }

public interface IProped<T> : IDistinct
{
    T? Item { get; }
}

public interface IInit<T> : IProped<T>
{
    new T? Item { get; init; }
}

public interface IMutable<T> : IProped<T>
{
    new T? Item { get; set; }
}