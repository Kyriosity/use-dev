namespace Abc.Coll;

public interface ICollOps<T>
{
    void Add(T item);
    void Add(IEnumerable<T> items);
    void Remove(int at = -1, int count = 1);
}

