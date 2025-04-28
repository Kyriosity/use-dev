namespace ISie_Eval.BuiltinTypes.String;

public class Demo : Setup.Arrange
{
#if DEBUG
    [Test]
#endif
    public void Shortcuts() {
        _ = string.IsNullOrEmpty(anyText);
        _ = anyText.Is().NullOrEmpty; // 👈 no literal overhead

        _ = string.IsNullOrWhiteSpace(""); // ⚠️ empty is admitted as whitespace but it's not
        _ = "".Is().NullEmptyOr.Whitespace;
        _ = anyText.Is().EmptyOr.Whitespace; // 👈 doesn't soft-pedal Null
        _ = "\n".Is().Whitespace; // 👈 must contain at least one
    }

#if DEBUG
    [Test]
#endif
    public void NewFeat_PureSpaces() {
        tryMe = anyText.Is().Spaces;

        True = " ".Is().SingleSpace;

        False = "".Is().Whitespace;

        False = "".Is().Spaces;
        False = "  \n  ".Is().Spaces;
    }

#if DEBUG
    [Test]
#endif
    public void Blank() {
        False = "".Is().Whitespace;
        False = "".Is().Spaces;
        True = " ".Is().Spaces;
        True = "    ".Is().Spaces;
        False = "  \n  ".Is().Spaces;

        False = "".Is().SingleSpace;
        True = "".Is().SingleSpace;
        False = "       ".Is().SingleSpace;

        True = "not whitespace".Is().EmptyOr.Whitespace;

        True = " ".Is().EmptyOr.Spaces;
        False = "       ".Is().SingleSpace;

        _ = "text".Is().NullEmptyOr.Whitespace;
        _ = "text".Is().NullEmptyOr.Spaces;
        False = "text".Is().NullEmptyOr.SingleSpace;

        False = "t e x t".Is().EmptyOr.Whitespace;
    }

#if DEBUG
    [Test]
#endif
    public void EmptyIsNotSpaceOrWhitespace() {
        False = "".Is().Whitespace;
        False = "".Is().Spaces;
        False = "".Is().SingleSpace;

        True = "".Is().EmptyOr.Whitespace;
    }

#if DEBUG
    [Test]
#endif
    public void Grayspace() {
        // RESERVED for concept discussion!
        _ = "a_b,c D".Is().Grayspace;
        _ = "        ".Is().Grayspace;
    }
}