using AbcStruct.Heap.Core;
using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Make;

internal class bagTry<TId, TCore> : ITryOps<TId> where TId : notnull where TCore : Default, new()
{
    protected TCore _core = new TCore();

    public bool Put<T>(TId id, T? val) {
        return _core.Add(id, val);
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
