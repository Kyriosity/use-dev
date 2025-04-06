// ReSharper disable InconsistentNaming
namespace AbcExtNUnit.Asserted;
public class Variable : Strings
{
    // Tribute to and mix of FORTRAN and ALGOL68 - https://en.wikipedia.org/wiki/Relational_operator#cite_note-6

    public Dictionary<KeyWrap, Socket> Eq = new();

    public Dictionary<KeyWrap, Socket> NE = new();
    public Dictionary<KeyWrap, Socket> Gt = new();
    public Dictionary<KeyWrap, Socket> Lt = new();
    public Dictionary<KeyWrap, Socket> GE = new();
    public Dictionary<KeyWrap, Socket> LE = new();

    // ToDesign:
    // - Multiple values
    // - Range
    // - Compare
    // - Custom func
}

public class Socket // ToDesign: name !
{
    public static implicit operator Socket(int assigned) {
        // GET CURRENT KEY ?

        return new Socket();
    }
}


public class KeyWrap
{
    public static implicit operator KeyWrap(int assigned) {
        // GET CURRENT KEY ?

        return new KeyWrap();
    }
}