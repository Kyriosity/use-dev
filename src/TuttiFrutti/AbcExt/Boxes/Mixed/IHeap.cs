namespace AbcExt.Boxes.Mixed;
public interface IHeap
{
    void Put<TId, TVal>(TId id, TVal? value) where TId : notnull;
    bool Pick<TId, TVal>(TId id, out TVal? value) where TId : notnull;
    void EnsureNone<TId, TVal>(TId id) where TId : notnull;
}
