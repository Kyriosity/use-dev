namespace ISie_Eval.BuiltinTypes.String_Encoding;
public class Demo : Setup.Arrange
{
#if DEBUG
    [Test]
#endif
    public void Ascii() {
        True = "hallo there 123".Is.Ascii;
        True = "<-abc_123+   @".Is.Ascii;
    }

#if DEBUG
    [Test]
#endif
    public void Not_Ascii() {
        False = "UNICODE is NOT \u1234 ASCII".Is.Ascii;
        False = "123😿abc".Is.Ascii;
        False = "Greek Δ".Is.Ascii;
        False = "DE ü".Is.Ascii;
    }

#if DEBUG
    [Test]
#endif
    public void Ascii_Controls() {
        True = "\0x00 Abc \n 123".Is.Ascii;
        False = "\0x00 Abc \n 123 ".Is.Ascii.NoControls;

        True = "Abc 123  \x7F".Is.Ascii;
        False = "Abc 123  \x7F".Is.Ascii.NoControls; // 👈  last character - BACKSPACE
    }

#if DEBUG
    [Test]
#endif
    public void WithPrecheck() {
        True = "abc_123".Is.NullEmptyOr.Ascii;
        True = "Ascii-table".Is.EmptyOr.Ascii;

        True = "not empty!".Is.NullEmptyOr.Ascii.NoControls;
        False = "with control: \t".Is.NullEmptyOr.Ascii.NoControls;
    }

    [SyntaxDemo]
    public void ExpectedExceptions() {
        ErrTemp = NullReference => NullStr.Is.Ascii;
        ErrTemp = Empty => "".Is.Ascii;
    }
}

