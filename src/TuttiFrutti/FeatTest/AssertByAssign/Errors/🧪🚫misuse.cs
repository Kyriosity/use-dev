namespace FeatTest.AssertByAssign.Errors;
public class Misuse : Basal
{
    [SyntaxDemo]
    public void CaseSensitive() {

        Error = ArithmeticEXCEPTION => DivideBy(0);
    }
}
