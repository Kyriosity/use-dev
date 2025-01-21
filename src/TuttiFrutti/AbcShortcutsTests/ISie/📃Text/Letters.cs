using AbcShortcutsTests.Setup;

namespace AbcShortcutsTests.ISie.Text;
public class Letters : Arrange // : TestBedRock
{
    [Test]
    public void DefaultAlphabet_Latin() {
        Assert.That(1, Is.EqualTo(1).Within(1).Within(1).Percent.Ulps);

        //protected bool WillBeTrue = true;

        //if ("Abvsdfs".Is().Letters)
        //_ = false == "Abvsdfs123".Is().Letters;

        //_ = false == text.Is().Abc.NuWithWhitespace.Separators.MathSymbols; // MATH SYMBS only FOR NUMERIC VAR ?!
    }

    [SyntaxDemo]
    public void ExplicitAlphabets() {
        //WillBeTrue = "".Is().Ascii.Printable;

        //WillBeTrue = "".Is<Japanese>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Japanese.Kanji>().EmptyOr.Whitespace;

        //WillBeTrue = "".Is<Greek>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Bosnian.Latin>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Bosnian.Cyrillic>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Mongolian.Cyrillic>().EmptyOr.Whitespace;

        //WillBeTrue = "".Is<Current>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Current.UI>().EmptyOr.Whitespace;
        //bool __ = "".Is<PratoIndian>().EmptyOr.Whitespace;
    }
}
