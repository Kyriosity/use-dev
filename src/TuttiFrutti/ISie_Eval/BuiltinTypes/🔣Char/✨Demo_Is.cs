namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_Is : Setup.Arrange
{
    [Test]
    public void Alphanumeric() {
        True = 'ö'.Is().Letter;
        True = 'ß'.Is().LetterOrDigit;
        True = '9'.Is().Digit;

        True = ','.Is().Punctuation;
        True = '\t'.Is().Whitespace;
        True = Glyph.Marks.Paragraph.Is().Separator;

        True = '\u0001'.Is().Control;
        True = '+'.Is().Symbol;
    }

    [Test]
    public void Range() {
        True = 'x'.Is().Between('a', 'z');
        False = 'X'.Is().Between('C', 'T');

        True = 'δ'.Is().Lower;
        True = 'Δ'.Is().Upper;
        False = 'Δ'.To().Lower.Is().Upper;
    }

    [Test]
    public void Surrogate() {
        True = '\uDFFF'.Is().Surrogate;
        True = '\uD800'.Is().Surrogate.High;
        True = '\uDC00'.Is().Surrogate.Low;

        False = '1'.Is().Surrogate;
    }
}
