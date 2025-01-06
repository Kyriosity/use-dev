using AbcDataOps.ISie;

namespace AbcShortcutsTests.ISie.Text;
public class DemoIs
{
    [Ignore("syntax demo which can fail before implemented")]
    public void Filling() {
        bool @is; var text = "doesnt matter";
        @is = text.Is().NullOr.Empty;
        @is = text.Is().NullOr.EmptyOr.Whitespace;
        @is = text.Is().NullOr.EmptyOr.SingleSpace;
        @is = text.Is().NullOr.EmptyOr.Spaces;

        @is = text.Is().EmptyOr.SingleSpace; // null will throw here
        @is = text.Is().EmptyOr.Whitespace;
        @is = text.Is().EmptyOr.Spaces;
    }
}