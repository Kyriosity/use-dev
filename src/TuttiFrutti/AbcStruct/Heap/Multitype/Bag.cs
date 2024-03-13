using AbcStruct.Heap.Multitype.Implement;
using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype;
public static class Bag
{
    public static IDirectOps<string> New() => New<string>();

    public static IDirectOps<TId> New<TId>() where TId : notnull => new bag<TId> { };

    public static IDirectOps<TId> New<TId, T>(TId id, T val) where TId : notnull {
        var bag = New<TId>();
        bag.Put(id, val);
        return bag;
    }

    public static class WithTry
    {
        public static IWithTryOps<string> New() => New<string>();
        public static IWithTryOps<TId> New<TId>() where TId : notnull => new bagWithTry<TId> { };

        public static IWithTryOps<TId> New<TId, T>(TId id, T val) where TId : notnull {
            var bag = New<TId>();
            bag.Put(id, val);
            return bag;
        }
    }

    public static class TryOnly
    {
        public static ITryOps<string> New() => New<string>();
        public static ITryOps<TId> New<TId>() where TId : notnull => new bagTry<TId> { };

        public static ITryOps<TId> New<TId, T>(TId id, T val) where TId : notnull {
            var bag = New<TId>();
            return bag.Put(id, val) ? bag : throw new Exception
                ($"Failed to init {nameof(TryOnly)} with {nameof(id)}{id}, {nameof(val)}: {val}");
        }
    }
}