namespace Abc.Coll.Def;

public interface ICollOps<T>
{
    void Add(T item);
    void Add(IEnumerable<T> items);
    void Remove(int at = -1, int count = 1);
}

public interface IItemsAccu<T> : ICollOps<T> //, IAdjustedInput<T>
{
    T this[int index] { get; }
    IReadOnlyCollection<T> Items { get; }
}