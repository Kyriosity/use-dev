using AbcDataOps.Text.Ext.Usual;

namespace AbcShortcutsTests.Text.Usual.Plus;
public class Demo
{
    [Test]
    public void BlankTraits() {
        const string nullText = null;

        Assert.That(
            nullText.IsNullEmptyOrSpaces() && "".IsNullEmptyOrSpaces() &&
            " ".IsNullEmptyOrSpaces() && "    ".IsNullEmptyOrSpaces() && !"test".IsNullEmptyOrSpaces(),
    Is.True);

        Assert.That(
            nullText.IsNullEmptyOrSingleSpace() && "".IsNullEmptyOrSingleSpace() &&
            " ".IsNullEmptyOrSingleSpace() && !"    ".IsNullEmptyOrSingleSpace() && !"test".IsNullEmptyOrSingleSpace(),
        Is.True);
    }
}