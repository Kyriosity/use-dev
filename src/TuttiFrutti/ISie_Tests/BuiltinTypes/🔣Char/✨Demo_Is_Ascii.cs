using ISie.Char;

namespace ISie_Tests.BuiltinTypes.Char;
public class Demo_Is_Ascii : Setup.Arrange
{
#if DEBUG
    [Test]
#endif
    public void General() {
        True = char.IsAscii('a');
        _ = 'a'.Is().Ascii;


        // LetterOr
        // Letter + .Upper / Lower

        char.IsAsciiDigit('a');

        char.IsAsciiHexDigit('a');
        char.IsAsciiHexDigitLower('a');
        char.IsAsciiHexDigitUpper('a');
        char.IsAsciiLetterOrDigit('b');
    }

#if DEBUG
    [Test]
#endif
    public void LetterCase() {
        True = 'd'.Is().Ascii.Letter.Lower;
        True = 'D'.Is().Ascii.Letter.Upper;
    }

}
