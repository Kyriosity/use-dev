using AbcModels.Bits.Marked;

namespace TuttiFruttiDemo.VM;

public interface IBase : ITitled, INotifyPropertyChanged
{
    void NotifyUpdate(string name);
}
