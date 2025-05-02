// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace ISie_Eval.BuiltinTypes.String.Tests;
public class ErrorsAndExceptions : Setup.Arrange
{
    [Test]
    public void When_NULL_not_checked() {
        Error = NullReference => NullStr.Is().EmptyOr.Whitespace;
        Error = NullReference => NullStr.Is().Whitespace;
        Error = NullReference => NullStr.Is().Ascii;
    }

#if DEBUG
    [Test]
#endif
    public void When_EMPTY_not_checked() {
        // implicit operator doesn't work in descending class ...
        _ = "".Is().Ascii;
        //Error = Empty => "".Is().Ascii;
        // ... unless explicitly assigned as next
        if ("".Is().Ascii) ;
    }
}