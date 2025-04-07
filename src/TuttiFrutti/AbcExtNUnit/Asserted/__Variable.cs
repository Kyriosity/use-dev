// ReSharper disable InconsistentNaming
namespace AbcExtNUnit.Asserted;
public class Variable : Strings
{
    // Tribute to and mix of FORTRAN and ALGOL68 - https://en.wikipedia.org/wiki/Relational_operator#cite_note-6

    public Dictionary<KeyWrap, Mediator> Eq = new();

    public Dictionary<KeyWrap, Mediator> NE = new();
    public Dictionary<KeyWrap, Mediator> Gt = new();
    public Dictionary<KeyWrap, Mediator> Lt = new();
    public Dictionary<KeyWrap, Mediator> GE = new();
    public Dictionary<KeyWrap, Mediator> LE = new();

    // ToDesign:
    // - Multiple values
    // - Range
    // - Compare
    // - Custom func
}

public class Mediator // ToDesign: name !
{
    public static implicit operator Mediator(int assigned) {
        // GET CURRENT KEY ?

        return new Mediator();
    }
}


public class KeyWrap
{
    public static implicit operator KeyWrap(int assigned) {
        // GET CURRENT KEY ?

        return new KeyWrap();
    }
}