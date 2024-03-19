namespace AbcStruct.Heap.Core;
public interface IInput
{
    virtual T? XLat<T>(T? origin) {
        return origin;
    }
}
