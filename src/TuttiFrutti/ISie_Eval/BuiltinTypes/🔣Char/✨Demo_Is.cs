using ISie.Char;

namespace ISie_Eval.BuiltinTypes.ISie.Char;
public class Demo_Is : Setup.Arrange
{
    [Test]
    public void Alphanumeric() {
        True = 'ö'.Is().Letter;
        True = 'ß'.Is().LetterOrDigit;
        True = '9'.Is().Digit;

        True = ','.Is().Punctuation;
        True = '\t'.Is().Whitespace;
        True = '\u2029'.Is().Separator; // paragraph

        True = '\u0001'.Is().Control;
        True = '+'.Is().Symbol;
    }

    [Test]
    public void Range() {
        True = 'x'.Is().Between('a', 'z');
        False = 'X'.Is().Between('C', 'T');

        True = 'δ'.Is().Lower;
        True = 'Δ'.Is().Upper;
    }

    [Test]
    public void Surrogate() {
        _ = '\uDFFF'.Is().Surrogate;
        True = '\uD800'.Is().Surrogate.High;
        True = '\uDC00'.Is().Surrogate.Low;
    }
}
