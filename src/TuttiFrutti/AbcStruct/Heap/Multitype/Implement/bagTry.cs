using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;

internal class bagTry<TId, TStuff> : ITryOps<TId> where TId : notnull where TStuff : ICore, IInput, new()
{
    protected TStuff _core = new TStuff();

    public bool Put<T>(TId id, T? val) {
        return _core.Add(id, _core.XLat(val));
    }

    public bool Take<T>(TId id, out T? val) {
        if (_core.Find(id, out val))
            return _core.Remove<TId, T>(id);

        return false;
    }

    public bool Read<T>(TId id, out T? val) {
        return _core.Find(id, out val);
    }
}
