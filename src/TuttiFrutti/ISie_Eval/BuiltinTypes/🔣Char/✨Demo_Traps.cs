namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_Traps : Setup.Arrange
{
    [Test]
    public void You_Must_Check_for_Null() {
        char? sample = 'a';

        //_ = sample.Is().Ascii;
    }
}
