namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_Is_Ascii : Arrange
{
#if DEBUG
    [Test]
#endif
    public void General() {
        True = 'd'.Is.Ascii;
        False = '§'.Is.Ascii;
        True = '§'.Not.Ascii;

        True = 'W'.Is.Ascii.LetterOrDigit;
        True = '5'.Is.Ascii.LetterOrDigit;
        False = ','.Is.Ascii.LetterOrDigit;
    }

    [Test]
    public void Letters() {
        True = 'D'.Is.Ascii.Letter;
        False = 'D'.Not.Ascii.Letter;
        True = 't'.Is.Ascii.Letter.Lower;
        True = 'T'.Is.Ascii.Letter.Upper;

        False = '9'.Is.Ascii.Letter;
        False = 'Λ'.Is.Ascii.Letter;
        True = 'Λ'.Not.Ascii.Letter;
    }

    [Test]
    public void Digits() {
        True = '5'.Is.Ascii.Digit;
        False = 'a'.Is.Ascii.Digit;
        False = '.'.Is.Ascii.Digit;
    }

    [Test]
    public void HexDigits() {
        True = '5'.Is.Ascii.HexDigit;
        False = '5'.Is.Ascii.HexDigit.Lower;
        False = '5'.Is.Ascii.HexDigit.Upper;

        True = 'g'.Not.Ascii.HexDigit;
        False = 'G'.Is.Ascii.HexDigit.Upper;

        True = 'a'.Is.Ascii.HexDigit;
        True = 'c'.Is.Ascii.HexDigit.Lower;
        True = 'F'.Is.Ascii.HexDigit.Upper;
    }
}