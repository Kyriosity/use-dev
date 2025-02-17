namespace FeatTest.Shortcuts.Attributes;
using AbcExtNUnit.Attributes.Case;

public class TestCases
{
    [TestCase("Abc")]
    [Test("Abc")] // 👈🏿 AbcExtNUnit..
    public void SingleCase_SingleArgument(string arg) { Assert.That(arg, Is.EqualTo("Abc")); }

    [TestCase(-5, "name", true)]
    [Test(-5, "name", true)] // 👈🏿 AbcExtNUnit..
    public void SingleCase_Multiargument(int id, string title, bool isForTest) {
        Assert.That(id, Is.EqualTo(-5));
        Assert.That(title, Is.EqualTo("name"));
        Assert.That(isForTest, Is.True);
    }

    [TestCase(-5), TestCase(-20), TestCase(-20), TestCase(-33), TestCase(-40), TestCase(-500)]
    [Many(-5, -20, -33, -40, -500)] // 👈🏿 AbcExtNUnit..
    public void MultiCases_SingleArgument(short core) { Assert.That(core, Is.LessThan(-4)); }

    [TestCase(1, "Book", true), TestCase(11, "DVD", false), TestCase(111, "Magazine", true)]
    [Many([1, "Book2", true], [11, "DVD2", false], [111, "Magazine2", true])] // 👈🏿 AbcExtNUnit..
    public void MultiCases_MultiArgument(int id, string title, bool? on) {
        Assert.That(id, Is.Positive);
        Assert.That(title, Is.Not.Empty);
        Assert.That(on, Is.Not.Null);
    }
}