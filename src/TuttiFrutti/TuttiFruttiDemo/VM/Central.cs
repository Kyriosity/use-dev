
namespace TuttiFruttiDemo.VM;

public class Central : BaseView // ToDo: Parametrize (Generic etc.)
{
    public Central() {
        Root = (BaseView)this;
        Desendants = [Books, UVals];
    }

    public Bookstore Books { get; set; }
    public BaseView UVals { get; set; }

    public override string Name => "Tutti-Frutti - Demo";
}
