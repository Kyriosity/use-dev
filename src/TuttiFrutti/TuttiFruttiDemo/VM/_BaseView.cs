namespace TuttiFruttiDemo.VM;

public abstract class BaseView : IBase
{
    public required BaseView Root { get; init; }
    public IEnumerable<BaseView> Desendants { get; init; } = [];
    public required IBase Commands { get; init; }

    public abstract string Name { get; }


    public event PropertyChangedEventHandler PropertyChanged = (_, __) => { };

    public void NotifyUpdate([CallerMemberName] string name = "-not/set-") =>
        PropertyChanged(this, new PropertyChangedEventArgs(name));
}
