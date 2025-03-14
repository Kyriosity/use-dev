namespace ISie_Tests.BuiltinTypes.String_Encoding;
public class Demo : Setup.Arrange
{
    [SyntaxDraft]
    public void Ascii() {
        True = "abc_123".Is().Ascii;
        True = "abc_123".Is().Ascii.NoControls;

        False = " \u1234 ".Is().Ascii;
    }

    [SyntaxDraft]
    public void WithDisjunction() {
        True = "abc_123".Is().NullEmptyOr.Ascii;
        _ = "abc_123".Is().EmptyOr.Ascii;
        _ = "abc_123".Is().Ascii.NoControls;
        _ = "abc_123".Is().NullEmptyOr.Ascii.NoControls;
    }

    [Test]
    public void TestWiz() {


        bool rootFull = "".Is().Ascii.NoControls;
    }
}
