namespace Abc.Logic.Circuitry.Bool;
public interface IO : IO<bool>;

public interface IOWire : IO
{
    new bool Plug(bool val) => val;
}

public interface IOInverter : IO
{
    new bool Plug(bool val) => !val;
}

public interface IOTrue : IO
{
    new bool Plug(bool _) => true;
}

public interface IOFalse : IO
{
    new bool Plug(bool _) => false;
}

// ToDesign: Random? nullable?
