namespace ISie_Eval.BuiltinTypes.String.Lingua;
public class Demo_Alphabets : Arrange
{
    [SyntaxDraft]
    public void ExplicitAlphabet() {
        const string greek = "Θεσσαλονίκη";
        //True = greek.Is<Greek>().Letters.AllowWhitespace;
        //False = ("Greek " + greek).Is<Greek>().Letters.AllowWhitespace;

        //WillBeTrue = "".Is<Current>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Current.UI>().EmptyOr.Whitespace;
        //bool __ = "".Is<PratoIndian>().EmptyOr.Whitespace;
    }

    [SyntaxDraft]
    public void MultipleAlphabets() {

        //_ = "math".Is<English, Latin>();
    }

    [SyntaxDraft]
    public void Multiscript() {
        //WillBeTrue = "".Is<Bosnian.Latin>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Bosnian.Cyrillic>().EmptyOr.Whitespace;
        //WillBeTrue = "".Is<Mongolian.Cyrillic>().EmptyOr.Whitespace;

        //_ = "".Is<Japanese>().Text;
        //_ = "".Is<Japanese.Kanji>();
    }

    [SyntaxDraft]
    public void CurrentCulture() {

    }
}