namespace AbcCircuitry.Bool;
public interface IO : IO<bool>;

public interface IOInverter : IO
{
    new Func<bool, bool> Plug => val => !val;
}

public interface IOTrue : IO
{
    new Func<bool, bool> Plug => _ => true;
}

public interface IOFalse : IO
{
    new Func<bool, bool> Plug => _ => false;
}