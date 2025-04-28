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

        Error = NullReference => NullStr.Is().Ascii.NoControls;
    }

    [Test]
    public void When_EMPTY_not_checked() {
        AbcCommu.Errors.Data.Empty.Throw();

        Error = Empty => "".Is().Ascii;
    }
}