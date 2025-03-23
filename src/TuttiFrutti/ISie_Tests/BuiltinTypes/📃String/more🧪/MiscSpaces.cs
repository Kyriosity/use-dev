using AbcExtNUnit.Attributes.Case;

namespace ISie_Tests.BuiltinTypes.String.more;
public class MiscSpaces : Setup.Arrange
{
    [Many("", spaces.Single, "       ", "   ", "                     ")]
    public void SingleSpace(string subj) {

    }

    [Many("", spaces.Single, "       ", "   ", "                     ")]
    public void AnySpaces(string subj) {
        Assert.That(subj.Is().Spaces, Is.True);
        Assert.That(subj.Is().EmptyOr.Spaces, Is.True);
        Assert.That(subj.Is().NullEmptyOr.Spaces, Is.True);
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