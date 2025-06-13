namespace ISie_Eval.BuiltinTypes.String.Blanks;

public class Demo : Arrange
{
#if DEBUG
    [Test]
#endif
    public void Shortcuts() {
        True = string.IsNullOrEmpty("abc") == "abc".Is.NullOrEmpty; // 👈 no overhead
        True = !string.IsNullOrEmpty(anyText) == anyText.Not.NullOrEmpty;

        _ = string.IsNullOrWhiteSpace(""); // ⚠️ empty is admitted as whitespace but it's not
        _ = "".Is.NullEmptyOr.Whitespace; // 👈 explicitly specifies empty
        _ = anyText.Is.EmptyOr.Whitespace; // 👈 doesn't soft-pedal Null
        _ = "\n".Is.Whitespace; // 👈 must contain at least one
    }

#if DEBUG
    [Test]
#endif
    public void NewFeature_PureSpaces() {
        tryMe = anyText.Is.Spaces;

        True = " ".Is.SingleSpace;
        False = " ".Not.SingleSpace;

        False = "".Is.Whitespace;
        True = "".Not.Whitespace;
        True = "   ".Is.Whitespace;

        False = "".Is.Spaces;
        False = "  \n  ".Is.Spaces;
        True = "  ".Is.Spaces;
    }

#if DEBUG
    [Test]
#endif
    public void BlanksAndGaps() {
        False = "".Is.Whitespace;
        True = "".Not.Spaces;
        True = " ".Is.Spaces;
        True = "    ".Is.Spaces;
        False = "  \n  ".Is.Spaces;

        True = " ".Is.SingleSpace;
        False = "".Is.SingleSpace;
        True = "       ".Not.SingleSpace;

        False = "not whitespace".Is.EmptyOr.Whitespace;

        True = " ".Is.EmptyOr.Spaces;
        True = "       ".Is.Spaces;

        _ = "text".Is.NullEmptyOr.Whitespace;
        _ = "text".Is.NullEmptyOr.Spaces;
        False = "text".Is.NullEmptyOr.SingleSpace;

        False = "t e x t".Is.EmptyOr.Whitespace;
    }

#if DEBUG
    [Test]
#endif
    public void EmptyIsNotSpaceOrWhitespace() {
        False = "".Is.Whitespace;
        False = "".Is.Spaces;
        False = "".Is.SingleSpace;

        True = "".Is.EmptyOr.Whitespace;
    }

    [SyntaxDraft]
    public void Grayspace() {
        // RESERVED for discussions!
        False = "a_b,c D".Is.Grayspace;
        _ = "  _ ,     ".Is.Grayspace;
        _ = "Apple".Replace(" ", "_");

    }
}