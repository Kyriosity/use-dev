using AbcDataOps.Text.Ext.Usual;

namespace AbcShortcutsTests.Text.Usual;

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
    public void BlankTraits_Changed() {
        var textToModify = string.Empty;

        textToModify += "  ";
        Assert.That(
            textToModify.IsNullOrWhiteSpace() && !textToModify.IsNullOrEmpty(),
            Is.True);

        textToModify += ".";
        Assert.That(
            textToModify.IsNullOrWhiteSpace(),
            Is.False);
    }
}