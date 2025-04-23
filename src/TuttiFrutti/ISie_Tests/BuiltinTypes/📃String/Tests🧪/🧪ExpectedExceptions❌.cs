// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace ISie_Tests.BuiltinTypes.String.Tests;
public class ErrorsAndExceptions : Setup.Arrange
{
    [Test]
    public void OnNull() {
        Error = NullReferenceException => NullStr.Is().Ascii.NoControls;
    }
}
