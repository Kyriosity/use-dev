using Abc.Xform;

namespace Abc.Coll;

public interface IItemsAccu<T> : ICollOps<T>
{
    T this[int index] { get; }
    IReadOnlyCollection<T> Items { get; }
}

public interface IAdjustedItems<T> : IItemsAccu<T>, IAdjustedInput<T> { }