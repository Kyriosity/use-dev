using AbcStruct.Heap.Core;
using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Make;
internal class bagWithTry<TId, TCore> : bag<TId, TCore>, IWithTryOps<TId>
    where TId : notnull where TCore : Default, new()
{
    public ITryOps<TId> Could => _could;
}
