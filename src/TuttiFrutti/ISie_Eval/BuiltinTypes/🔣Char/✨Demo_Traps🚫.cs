namespace ISie_Eval.BuiltinTypes.Char;
public class Demo_Traps : Setup.Arrange
{
    [Test]
    public void You_Must_Check_for_Null() {
        char? symb = 'W';
        True = symb.Is().Letter;
        True = 'w' == symb.To().Lower;

        symb = null;
        Error = ArgumentNull => symb.Is().Letter;
        Error = ArgumentNull => symb.To().Lower;
    }
}
