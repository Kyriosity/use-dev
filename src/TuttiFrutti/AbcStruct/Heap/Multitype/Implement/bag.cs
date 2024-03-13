using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;
internal class bag<TId> : IDirectOps<TId> where TId : notnull
{
    protected ITryOps<TId> _can = new bagTry<TId> { };

    public void Put<T>(TId id, T? val) => _ = _can.Put(id, val) ? true : UniqueConstraint.Throw(id);

    public T? Read<T>(TId id) => _can.Read(id, out T? val) ? val : EntityNotFound.Throw(id);

    public T? Take<T>(TId id) => _can.Take(id, out T? val) ? val : EntityNotFound.Throw(id);


}
