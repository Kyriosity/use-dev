namespace ISie_Tests.BuiltinTypes.String_Encoding;
public class Demo : Setup.Arrange
{
#if DEBUG
    [Test]
#endif
    public void Ascii() {
        True = "abc\n123".Is().Ascii; // ToDo: ADD CONTRAL ASCII
        True = "abc_123".Is().Ascii.NoControls;

        False = " NOT\u1234ASCII".Is().Ascii;
        False = "123😿579".Is().Ascii;
    }

#if DEBUG
    [Test]
#endif
    public void WithPrecheck() {
        True = "abc_123".Is().NullEmptyOr.Ascii;
        _ = "abc_123".Is().EmptyOr.Ascii;
        _ = "abc_123".Is().Ascii.NoControls;
        _ = "abc_123".Is().NullEmptyOr.Ascii.NoControls;

    }
#if DEBUG
    [Test]
#endif
    public void TestWiz() {

        True = "START 1".Is().Ascii.NoControls;
    }
}

