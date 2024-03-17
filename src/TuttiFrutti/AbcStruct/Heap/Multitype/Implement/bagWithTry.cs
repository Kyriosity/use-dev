using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;
internal class bagWithTry<TId, TStuff> : bag<TId, TStuff>, IWithTryOps<TId> where TId : notnull where TStuff : ICore, IInput, new()
{
    public ITryOps<TId> Could => _could;
}
