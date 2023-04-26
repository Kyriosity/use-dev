namespace Abc.Coll;
public interface IItemsAccu<T> : ICollOps<T>
{
    T this[int index] { get; }
    IReadOnlyCollection<T> Items { get; }
}

