namespace AbcStruct.Ops.Keyed.Multitype;

public interface IHeap;
public interface IHeap<in TId> where TId : notnull;

public interface IDirectOps<in TId> : IHeap<TId> where TId : notnull
{
    void Put<T>(TId id, T? val);
    T? Take<T>(TId id);
    T? Read<T>(TId id);
}

public interface ITryOps<in TId> : IHeap<TId> where TId : notnull
{
    bool Put<T>(TId id, T? val);
    bool Take<T>(TId id, out T? val);
    bool Read<T>(TId id, out T? val);
}

public interface IWithTryOps<in TId> : IDirectOps<TId> where TId : notnull
{
    ITryOps<TId> Could { get; }
}
