namespace ISie_Tests.BuiltinTypes.String.more;
public class NullEmptyTests : Setup.Arrange
{
    [Test]
    public void ExplicitProve() {
        Assert.That(NullStr.Is().NullOrEmpty, Is.True);
        Assert.That(string.Empty.Is().NullOrEmpty, Is.True);
        Assert.That(Spaces.Single.Is().NullOrEmpty, Is.False);
        Assert.That("      ".Is().NullOrEmpty, Is.False);
        Assert.That("test".Is().NullOrEmpty, Is.False);
    }

    [Test]
    public void DisjunctedProve() {
        Assert.That(NullStr.Is().NullEmptyOr.Whitespace, Is.True);
        Assert.That(string.Empty.Is().NullEmptyOr.Whitespace, Is.True);

        Assert.That(NullStr.Is().NullEmptyOr.SingleSpace, Is.True);
        Assert.That(string.Empty.Is().NullEmptyOr.SingleSpace, Is.True);

        Assert.That(NullStr.Is().NullEmptyOr.Spaces, Is.True);
        Assert.That(string.Empty.Is().NullEmptyOr.Spaces, Is.True);
    }
}
