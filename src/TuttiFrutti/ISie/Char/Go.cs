namespace ISie.Char;
public static class Go
{
    public static ICharMenu Is(this char c) => null;
}

public interface ICharMenu
{
    IAscii Ascii { get; }



}

public interface IAscii
{
    bool Digit { get; }
    bool LetterOrDigit { get; }

    ILetterCase HexDigit { get; } // Lower Upper

    ILetterCase Letter { get; } // Lower Upper

}

public interface ILetterCase
{
    bool Lower { get; }
    bool Upper { get; }
}
