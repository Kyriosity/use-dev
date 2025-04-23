namespace ISie_Eval.BuiltinTypes.String.Tests;
public class InvalidSyntax : Setup.Arrange
{
    [SyntaxDraft]
    public void InvalidCallsCheck() {
        //_ = "  \n  ".Is().NullEmptyOr.EmptyOr; // 🚫 Invalid semantics
        //_ = "text".Is().NullOr; // 🚫 Invalid Call !

        //_ = "text".Is().NullEmptyOr.Printable; // 🚫 Invalid Call !
        //_ = "text".Is().EmptyOr.Printable; // 🚫 Invalid Call !

        //_ = "text".Is().NullOrEmpty.Whitespace; // 🚫 Invalid Call !
    }

    [SyntaxDraft]
    public void InvalidCast() {
        _ = "test".Is().NullEmptyOr; // intermediate
        //bool result = "test".Is().NullEmptyOr;  // 🚫 Invalid cast !
        _ = "test".Is().EmptyOr;  // intermediate
        // bool result = "test".Is().EmptyOr;  // 🚫 Invalid cast !
    }
}
