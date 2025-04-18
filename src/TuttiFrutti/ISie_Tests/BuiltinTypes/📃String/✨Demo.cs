namespace ISie_Tests.BuiltinTypes.String;

public class Demo : Setup.Arrange
{
    [SyntaxDemo]
    public void Shortcut() {
        var dummy = "for demo only";

        _ = string.IsNullOrEmpty(dummy);
        _ = dummy.Is().NullOrEmpty;

        False = "D".Is().NullOrEmpty;

        True = "".Is().NullEmptyOr.Whitespace;

        True = "  \n  ".Is().NullEmptyOr.Whitespace;
        True = "  \n  ".Is().EmptyOr.Whitespace;
    }

    [SyntaxDemo]
    public void Blank() {
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


    [SyntaxDemo]
    public void EmptyIsNotSpaceOrWhitespace() {
        False = "".Is().Whitespace;
        False = "".Is().Spaces;
        False = "".Is().SingleSpace;

        // but it is in the native method
        True = string.IsNullOrWhiteSpace(string.Empty);
    }


    [SyntaxDraft]
    public void Grayspace() {
        // RESERVED for concept discussion!
        False = "a_b,c D".Is().Grayspace;
        True = "        ".Is().Grayspace;
    }
}