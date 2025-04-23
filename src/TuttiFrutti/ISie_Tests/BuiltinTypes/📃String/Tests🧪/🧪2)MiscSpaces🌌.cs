using AbcExtNUnit.Attributes.Case;

namespace ISie_Tests.BuiltinTypes.String.Tests;
public class MiscSpaces : Setup.Arrange
{
    [Many("", spaces.Single, "       ", "   ", "                     ")]
    public void SingleSpace(string subj) {

    }

    [Many("", spaces.Single, "       ", "   ", "                     ")]
    public void AnySpaces(string subj) {
        True = subj.Is().Spaces;
        True = subj.Is().EmptyOr.Spaces;
        True = subj.Is().NullEmptyOr.Spaces;
    }

    [Many("", "   test    ", " %  ", "      ___               ")]
    public void Not_AnySpaces(string subj) {

        TestBy(subj, false);
    }

    protected void TestBy(string subj, bool expected) {


        Assert.That(subj.Is().Spaces, Is.EqualTo(expected));
        Assert.That(subj.Is().EmptyOr.Spaces, Is.EqualTo(expected));
        Assert.That(subj.Is().NullEmptyOr.Spaces, Is.EqualTo(expected));

    }
}