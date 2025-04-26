namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_Is_Ascii : Setup.Arrange
{
#if DEBUG
    [Test]
#endif
    public void General() {
        True = 'd'.Is().Ascii;

        True = 'W'.Is().Ascii.LetterOrDigit;
        True = '5'.Is().Ascii.LetterOrDigit;
    }

    [Test]
    public void Letters() {
        True = 'D'.Is().Ascii.Letter;
        True = 't'.Is().Ascii.Letter.Lower;
        True = 'T'.Is().Ascii.Letter.Upper;
    }

    [Test]
    public void Digits() {
        True = '5'.Is().Ascii.Digit;

        True = 'a'.Is().Ascii.HexDigit;
        True = 'a'.Is().Ascii.HexDigit.Lower;
        True = 'A'.Is().Ascii.HexDigit.Upper;
    }
}