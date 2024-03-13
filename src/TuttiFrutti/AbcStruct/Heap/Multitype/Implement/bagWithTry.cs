using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;
internal class bagWithTry<TId> : bag<TId>, IWithTryOps<TId> where TId : notnull
{
    public ITryOps<TId> Can => _can;
}
