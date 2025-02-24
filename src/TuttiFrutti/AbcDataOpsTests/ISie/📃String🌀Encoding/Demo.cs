namespace AbcDataOpsTests.ISie.String_Encoding;
public class Demo : Setup.Arrange
{
    [SyntaxDraft]
    public void Ascii() {
        True = "abc_123".Is().Ascii;
        True = "abc_123".Is().Ascii.AllPrintable;
    }

    [SyntaxDraft]
    public void WithDisjunction() {
        _ = "abc_123".Is().NullEmptyOr.Ascii;
        _ = "abc_123".Is().EmptyOr.Ascii;
        _ = "abc_123".Is().Ascii.AllPrintable;
        _ = "abc_123".Is().NullEmptyOr.Ascii.AllPrintable;
    }
}
