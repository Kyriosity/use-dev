namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_To : Setup.Arrange
{
    [Test]
    public void Shortcut() {
        True = 'D' == 'd'.To().Upper;
        True = 'D' == 'd'.To().UpperInvariant;
        True = 'a' == 'A'.To().Lower;
        True = 'a' == 'A'.To().LowerInvariant;

        False = 'd' == 'A'.To().Lower;
    }

    public void InvariantCases() {
        /// https://www.moserware.com/2008/02/does-your-code-pass-turkey-test.html
    }
}
