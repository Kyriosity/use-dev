namespace AbcStruct.Heap.Multitype.Implement;
public class GlobalId : ICore, IInput
{
    IDictionary<string, IEnumerable> ICore.Dir { get; } = new Dictionary<string, IEnumerable>();
}
