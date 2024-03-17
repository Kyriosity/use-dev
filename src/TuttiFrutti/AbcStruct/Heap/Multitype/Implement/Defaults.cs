
namespace AbcStruct.Heap.Multitype.Implement;
public class Defaults : ICore, IInput
{
    IDictionary<string, IEnumerable> ICore.Dir { get; } = new Dictionary<string, IEnumerable>();
}

