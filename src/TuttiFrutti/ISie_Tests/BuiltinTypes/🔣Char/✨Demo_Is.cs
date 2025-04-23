namespace ISie_Tests.BuiltinTypes.ISie.Char;
public class Demo_Is : Setup.Arrange
{
    [SyntaxDraft]
    public void Char() {
        char.IsPunctuation('a');
        char.IsHighSurrogate('a');
        char.IsWhiteSpace('a');
        char.IsSeparator('a');

        char.IsControl('a');
        //char.IsSurrogatePair(' ');
        char.IsSymbol('s');
        // Digit


        //char.Is

        // To
    }
}
