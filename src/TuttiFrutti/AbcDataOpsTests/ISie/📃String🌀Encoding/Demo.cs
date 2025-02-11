namespace AbcDataOpsTests.ISie.String_Encoding;
public class Demo : Setup.Arrange
{
    [SyntaxDemo]
    public void Ascii() {
        True = "abc_123".Is().Ascii;
        True = "abc_123".Is().Ascii.AllPrintable;
    }

    [SyntaxDemo]
    public void WithDisjunction() {
        _ = "abc_123".Is().NullEmptyOr.Ascii;
        _ = "abc_123".Is().EmptyOr.Ascii;
        _ = "abc_123".Is().Ascii.AllPrintable;
        _ = "abc_123".Is().NullEmptyOr.Ascii.AllPrintable;
    }
}
