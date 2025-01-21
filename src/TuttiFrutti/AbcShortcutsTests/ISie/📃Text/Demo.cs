using Abc.Lingua.indo_euro.italic.romance.west.gallic;

namespace AbcShortcutsTests.ISie.Text;

public class DemoIs
{
    private bool @is;
    private const string text = "doesnt matter";


    [SyntaxDemo]
    public void BlankTraits() {
        @is = text.Is().NullOr.Empty;

        @is = text.Is().Whitespace;
        @is = text.Is().Spaces;
        @is = text.Is().SingleSpace;

        @is = text.Is().NullOr.Whitespace;
        @is = text.Is().NullOr.Spaces;
        @is = text.Is().NullOr.SingleSpace;
        //@is = text.Is().NullOr.Printable; // NOT COMPILABLE !

        //@is = text.Is().EmptyOr.Printable;  // NOT COMPILABLE !
        @is = text.Is().EmptyOr.Whitespace;
        @is = text.Is().EmptyOr.Spaces;
        @is = text.Is().SingleSpace; // ToDo: CODES SUPPORTED ?

        @is = text.Is().NullOr.EmptyOr.Whitespace;
        @is = text.Is().NullOr.EmptyOr.Spaces;
        @is = text.Is().NullOr.EmptyOr.SingleSpace;

        @is = text.Is().NullOr.EmptyOr.Ascii.Printable;
        //@is = text.Is().NullOr.EmptyOr.SingleSpace;
        //@is = text.Is().NullOr.EmptyOr.Spaces;

        //@is = text.Is().EmptyOr.SingleSpace; // null will throw here
        //@is = text.Is().EmptyOr.Whitespace;
        //@is = text.Is().EmptyOr.Spaces;

        // Whitespace.UNICODE;

        _ = text.Is<French>().Alphanumeric;
    }

    [SyntaxDemo]
    public void Ascii() {
        char.IsPunctuation('a');
        char.IsHighSurrogate('a');
        char.IsWhiteSpace('a');
        char.IsSeparator('a');

        char.IsAsciiDigit('a');
        char.IsAsciiHexDigit('a');
        char.IsAsciiHexDigit('a');
        char.IsAsciiHexDigitLower('a');
        char.IsAsciiHexDigitUpper('a');
        char.IsControl('a');
        //char.IsSurrogatePair(' ');
        char.IsSymbol('s');


        @is = text.Is().NullOr.EmptyOr.Ascii.Printable;
        _ = text.Is().NullOr.Ascii.Printable;
        @is = text.Is().NullOr.EmptyOr.Ascii.Printable;
        _ = text.Is().Ascii;
        @is = text.Is().Ascii.Printable;
        var aaa = text.Is().Ascii;
    }
}