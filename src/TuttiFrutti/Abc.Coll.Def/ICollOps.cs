namespace Abc.Coll;

public interface ICollOps<T>
{
    ICollOps<T> Add(T first, params T[] rest);
    ICollOps<T> Add(IEnumerable<T> items);
    ICollOps<T> RemoveFirst(int count = 1);
    ICollOps<T> RemoveLast(int count = 1);
    ICollOps<T> RemoveAt(int index, int count = 1);
}
