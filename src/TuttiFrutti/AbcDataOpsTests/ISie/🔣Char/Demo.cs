namespace AbcDataOpsTests.ISie.Char;
public class Demo : Setup.Arrange
{
    [SyntaxDemo]
    public void Char() {
        char.IsPunctuation('a');
        char.IsHighSurrogate('a');
        char.IsWhiteSpace('a');
        char.IsSeparator('a');

        char.IsAscii('a');
        char.IsAsciiDigit('a');
        char.IsAsciiHexDigit('a');
        char.IsAsciiHexDigit('a');
        char.IsAsciiHexDigitLower('a');
        char.IsAsciiHexDigitUpper('a');
        char.IsControl('a');
        //char.IsSurrogatePair(' ');
        char.IsSymbol('s');
    }
}
