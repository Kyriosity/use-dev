namespace Abc.Item;

public interface IDistinct { }
public interface IDistinct<T> : IDistinct { }

public interface IGet<T> : IDistinct<T>
{
    T? Value { get; }
}

public interface IInit<T> : IGet<T>
{
    new T? Value { get; init; }
}

public interface IMutable<T> : IGet<T>
{
    new T? Value { get; set; }
}

