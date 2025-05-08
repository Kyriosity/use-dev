namespace ISie_Eval.BuiltinTypes.String_Lingua;
public class Demo : Setup.Arrange
{
    [SyntaxDraft]
    public void LettersAndNumbers() {

        _ = "AbcDef".Is<Latin>().Letters;
        _ = " Hi  there ".Is<English>().Letters.AllowWhitespace;

        _ = "français".Is<French>().Alphanumeric;
        _ = "AbcüäßöXZY".Is<German>().Alphanumeric.AllowWhitespace;
    }

    [SyntaxDraft]
    public void In_AndEx_clusion() {
        //_ = "Asda".Has<Greek>().Letters; // HAS NO !!!
    }

    [SyntaxDraft]
    public void Text() {
        _ = "lorem ipsum.Et harum quidem reru[d]um facilis est e[r]t expedita distinctio."
            .Is<Latin>().Text;

        _ = "".Is<English>().Text.AllowMiscSymbols;
        _ = "".Is<English>().Text.AllowMiscSymbols.WithoutNumberInlays;
    }

    [SyntaxDraft]
    public void TestNew() {

        _ = "papier-mâché.".Is<French>().Text;
        _ = "good evening".Is<English>().Letters.AllowWhitespace;
        _ = "".Is<English>().Letters.AllowWhitespace;
    }
}


