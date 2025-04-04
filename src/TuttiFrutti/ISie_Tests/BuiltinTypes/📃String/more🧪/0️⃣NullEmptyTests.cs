﻿namespace ISie_Tests.BuiltinTypes.String.more;
public class NullEmptyTests : Setup.Arrange
{
    [Test]
    public void DirectProof() {
        True = NullStr.Is().NullOrEmpty;
        True = string.Empty.Is().NullOrEmpty;
        False = spaces.Single.Is().NullOrEmpty;
        False = "      ".Is().NullOrEmpty;
        False = "test".Is().NullOrEmpty;
    }

    [Test]
    public void Disjunct() {
        True = NullStr.Is().NullEmptyOr.Whitespace;
        False = string.Empty.Is().NullEmptyOr.Whitespace;

        True = string.Empty.Is().NullEmptyOr.Ascii;
        True = NullStr.Is().NullEmptyOr.Ascii.NoControls;

        True = NullStr.Is().NullEmptyOr.SingleSpace;
        True = string.Empty.Is().NullEmptyOr.SingleSpace;

        True = NullStr.Is().NullEmptyOr.Spaces;
        True = string.Empty.Is().NullEmptyOr.Spaces;
    }
}