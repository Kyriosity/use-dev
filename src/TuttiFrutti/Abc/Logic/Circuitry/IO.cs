namespace Abc.Logic.Circuitry;

public interface IO;

public interface IO<T> : IO
{
    T Plug(T val) => throw new NotImplementedException();
}

public interface IOWire<T> : IO<T>
{
    new T Plug(T val) => val;
}

public interface IODefault<T> : IO<T>
{
    new T Plug(T val) => val;
}
