namespace Abc.Circuitry;

public interface IO;

public interface IO<T> : IO
{
    Func<T, T> Plug { get; }
}

public interface IOWire<T> : IO<T>
{
    new Func<T, T> Plug => val => val;
}

public interface IODefault<T> : IO<T>
{
    new Func<T, T> Plug => _ => default;
}
