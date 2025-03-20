namespace ISie_Tests.BuiltinTypes.String;

public class Demo : Setup.Arrange
{
    [Test]
    public void Shortcuts() {
        True = NullStr.Is().NullOrEmpty;

        True = string.Empty.Is().NullOrEmpty;
        False = "D".Is().NullOrEmpty;

        True = string.Empty.Is().NullEmptyOr.Whitespace;
        False = string.Empty.Is().Whitespace;

        True = "  \n  ".Is().NullEmptyOr.Whitespace;

        True = "  \n  ".Is().EmptyOr.Whitespace; // must be exception
        _ = NullStr.Is().EmptyOr.Whitespace; // must be exception
    }

    [SyntaxDraft]
    public void Blank() {
        False = "".Is().Spaces;
        True = Spaces.Single.Is().Spaces;
        True = "    ".Is().Spaces;
        False = "  \n  ".Is().Spaces;

        False = string.Empty.Is().SingleSpace;
        True = Spaces.Single.Is().SingleSpace;
        False = "       ".Is().SingleSpace;

        True = "not whitespace".Is().EmptyOr.Whitespace;

        True = Spaces.Single.Is().EmptyOr.Spaces;
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
    }

    [SyntaxDraft]
    public void InvalidCallsCheck() {
        //_ = "  \n  ".Is().NullEmptyOr.EmptyOr; // 🚫 Invalid semantics
        //_ = "text".Is().NullOr; // 🚫 Invalid Call !

        //_ = "text".Is().NullEmptyOr.Printable; // 🚫 Invalid Call !
        //_ = "text".Is().EmptyOr.Printable; // 🚫 Invalid Call !

        //_ = "text".Is().NullOrEmpty.Whitespace; // 🚫 Invalid Call !
    }

    // INVALID CAST
    [SyntaxDraft]
    public void InvalidCast() {
        _ = "test".Is().NullEmptyOr; // intermediate
        //bool result = "test".Is().NullEmptyOr;  // 🚫 Invalid cast !
        _ = "test".Is().EmptyOr;  // intermediate
        // bool result = "test".Is().EmptyOr;  // 🚫 Invalid cast !
    }

    [SyntaxDraft]
    public void Grayspace() {
        // RESERVED for concept discussion!
        False = string.Empty.Is().Grayspace;
    }
}