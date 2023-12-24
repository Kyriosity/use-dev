namespace Abc.Ext.Boxes.Mixed;
public interface IHeap : IBox
{
    void Put<TId, TVal>(TId id, TVal? value);
    bool Pick<TId, TVal>(TId id, out TVal? value);
    void EnsureNone<TId, TVal>(TId id);
}


public interface IBox { }
