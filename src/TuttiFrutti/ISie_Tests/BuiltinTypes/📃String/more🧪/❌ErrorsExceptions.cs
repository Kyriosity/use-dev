// ReSharper disable InconsistentNaming
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace ISie_Tests.BuiltinTypes.String.more;
public class ErrorsAndExceptions : Setup.Arrange
{
    [Test]
    public void Null() {
        Throw = NullReferenceException => NullStr.Is().EmptyOr.Whitespace;
    }

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
