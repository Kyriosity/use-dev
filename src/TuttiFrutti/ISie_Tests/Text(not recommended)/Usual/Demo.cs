namespace AbcDataOpsTests.Text.Usual;

[Obsolete]
public class Demo
{
    private const string multilineWhitespaces = @"   
    
   ";

    private const string tabAmongSpaces = "   \t  ";


    [Test]
    public void BlankTraits() {
        Assert.That(
            string.Empty.IsNullOrWhiteSpace() && multilineWhitespaces.IsNullOrWhiteSpace() && tabAmongSpaces.IsNullOrWhiteSpace()
            && "".IsNullOrEmpty() && "         ".IsNullOrWhiteSpace(),
        NUnit.Framework.Is.True);

        Assert.That(
            " LOREM ipsum  ".IsNullOrWhiteSpace() || " ".IsNullOrEmpty(),
            NUnit.Framework.Is.False);
    }

    [Test]
    public void CallsOnNull() {
        string? nullableText = null;
        string text = null;

        Assert.That(
            nullableText.IsNullOrEmpty() && nullableText.IsNullOrWhiteSpace() &&
            text.IsNullOrEmpty() && ((string)null).IsNullOrWhiteSpace(),
            NUnit.Framework.Is.True);
    }

    [Test]
    public void BlankTraits_Changed() {
        var text = string.Empty;
        Assert.That(text.IsNullOrEmpty(), NUnit.Framework.Is.True);

        text += "  ";
        Assert.That(
            text.IsNullOrWhiteSpace() && !text.IsNullOrEmpty(),
            NUnit.Framework.Is.True);

        text += ".";
        Assert.That(
            text.IsNullOrWhiteSpace(),
            NUnit.Framework.Is.False);

        text = string.Empty;
        Assert.That(text.IsNullOrEmpty() && text.IsNullOrWhiteSpace(), NUnit.Framework.Is.True);

        string nulledText = null;
        Assert.That(nulledText.IsNullOrEmpty(), NUnit.Framework.Is.True);

        nulledText = "   ";
        Assert.That(nulledText.IsNullOrEmpty(), NUnit.Framework.Is.False);

    }

}

[Obsolete]
static class Methods
{
    public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
    public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);
    public static string? IsInterned(this string value) => string.IsInterned(value);

}
