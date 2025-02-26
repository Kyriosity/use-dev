namespace AbcDataOpsTests.ISie.String_Encoding;
public class Demo : Setup.Arrange
{
    [SyntaxDraft]
    public void Ascii() {
        True = "abc_123".Is().Ascii;
        True = "abc_123".Is().Ascii.AllPrintable;

        False = " \u1234 ".Is().Ascii;
    }

    [SyntaxDraft]
    public void WithDisjunction() {
        True = "abc_123".Is().NullEmptyOr.Ascii;
        _ = "abc_123".Is().EmptyOr.Ascii;
        _ = "abc_123".Is().Ascii.AllPrintable;
        _ = "abc_123".Is().NullEmptyOr.Ascii.AllPrintable;
    }

    [Test]
    public void TestWiz() {

        bool rootFull = "".Is().Ascii;
    }
}
