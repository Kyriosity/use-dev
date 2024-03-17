namespace AbcStruct.Heap.Multitype.Implement;
public interface IInput
{
    virtual T? XLat<T>(T? origin) {
        return origin;
    }
}
