namespace AbcDataOpsExtTests.Text.Usual;


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
        Is.True);

        Assert.That(
            " LOREM ipsum  ".IsNullOrWhiteSpace() || " ".IsNullOrEmpty(),
            Is.False);
    }

    [Test]
    public void CallsOnNull() {
        string? nullableText = null;
        string text = null;

        Assert.That(
            nullableText.IsNullOrEmpty() && nullableText.IsNullOrWhiteSpace() &&
            text.IsNullOrEmpty() && ((string)null).IsNullOrWhiteSpace(),
            Is.True);
    }

    [Test]
    public void BlankTraits_Changed() {
        var text = string.Empty;
        Assert.That(text.IsNullOrEmpty(), Is.True);

        text += "  ";
        Assert.That(
            text.IsNullOrWhiteSpace() && !text.IsNullOrEmpty(),
            Is.True);

        text += ".";
        Assert.That(
            text.IsNullOrWhiteSpace(),
            Is.False);

        text = string.Empty;
        Assert.That(text.IsNullOrEmpty() && text.IsNullOrWhiteSpace(), Is.True);

        string nulledText = null;
        Assert.That(nulledText.IsNullOrEmpty(), Is.True);

        nulledText = "   ";
        Assert.That(nulledText.IsNullOrEmpty(), Is.False);

    }

}

[Obsolete]
static class Methods
{
    public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
    public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);
    public static string? IsInterned(this string value) => string.IsInterned(value);

}
