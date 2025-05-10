// ReSharper disable CheckNamespace
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace ISie_Eval.BuiltinTypes.String.Tests;
public class NullEmptyTests : Setup.Arrange
{
    [Test]
    public void DirectProof() {
        True = NullStr.Is.NullOrEmpty;
        False = NullStr.Not.NullOrEmpty;

        True = string.Empty.Is.NullOrEmpty;
        False = string.Empty.Not.NullOrEmpty;

        False = spaces.Single.Is.NullOrEmpty;
        True = spaces.Single.Not.NullOrEmpty;

        False = "      ".Is.NullOrEmpty;
        True = "      ".Not.NullOrEmpty;

        False = "test".Is.NullOrEmpty;
        True = "test".Not.NullOrEmpty;
    }

    [Test]
    public void CutByPrecondition() {
        True = NullStr.Is.NullEmptyOr.Whitespace;
        True = "".Is.NullEmptyOr.Whitespace;

        True = "".Is.EmptyOr.Whitespace;
        False = "".Not.EmptyOr.Whitespace;

        True = "".Is.NullEmptyOr.Ascii;
        True = NullStr.Is.NullEmptyOr.Ascii;
        False = NullStr.Not.NullEmptyOr.Ascii;

        True = NullStr.Is.NullEmptyOr.SingleSpace;
        True = string.Empty.Is.NullEmptyOr.SingleSpace;

        True = NullStr.Is.NullEmptyOr.Spaces;
        True = string.Empty.Is.NullEmptyOr.Spaces;
    }


}