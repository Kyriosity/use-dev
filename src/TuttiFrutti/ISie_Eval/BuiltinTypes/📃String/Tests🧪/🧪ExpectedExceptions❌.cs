#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace ISie_Eval.BuiltinTypes.String.Tests;
public class ErrorsAndExceptions : Arrange
{
    [Test]
    public void When_NULL_not_checked() {
        /// Expression trees DONT support extensions
        /// ToDesign: workaround

        // Error = NullReference => NullStr.Is.SingleSpace;
        //Error = NullReference => NullStr.Is.Whitespace;
        //Error = NullReference => NullStr.Is.Ascii; // ! won't throw when no explicit assignment

        //Error = NullReference => NullStr.Is.EmptyOr.Whitespace;
    }

#if DEBUG
    [Test]
#endif
    public void When_EMPTY_not_checked() {
        // implicit operator doesn't work in descending class ...
        _ = "".Is.Ascii;
        _ = "".Not.Ascii;
        //Error = Empty => "".Is.Ascii;
        // ... unless explicitly assigned as next
        if ("".Is.Ascii) ;
    }
}