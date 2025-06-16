namespace FeatTest.AssertByAssign;
public class Demo : Arrange
{
    [SyntaxDemo]
    public void Basics() {
        Assert.That(TruthValueFunction("descriptive, meaningful but long"), Is.True);
        True = TruthValueFunction("dubious but terser"); // 👈 with emphasized test subjects 
        False = TruthValueFunction("💥 will fail");

        int operand = 0;
        Assert.That(5 * operand, Is.Zero);
        Zero = 5 * operand;

        operand++;
        Zero = operand; // 💥 will fail
    }

    [SyntaxDemo]
    public void NullOrEmpty() {
        string? checker = null;
        Assert.That(checker, Is.Null);
        Null = checker;
        NotNull = checker; // 💥 will fail 

        Assert.That(IdentityMap(""), Is.Not.Empty);
        NotEmpty = IdentityMap("");

        var blank = new List<int>();
        Assert.That(blank, Is.Empty);
        NotEmpty = blank;
    }
}
