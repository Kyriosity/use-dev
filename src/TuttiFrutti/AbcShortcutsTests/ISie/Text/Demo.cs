using AbcDataOps.ISie;

namespace AbcShortcutsTests.ISie.Text;
public class DemoIs
{
    [SyntaxDemo]
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

    [SyntaxDemo]
    public void Latin() {
    }
}