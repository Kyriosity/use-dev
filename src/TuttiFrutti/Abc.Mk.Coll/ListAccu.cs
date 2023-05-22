using Abc.Coll;

namespace Abc.Mk.Coll;

public class ListAccu<T> : AccuOnColl<T, List<T>>
{
    public override T this[int at] => _items[0 <= at ? at : _items.Count + at];
    public override ICollOps<T> RemoveFirst(int count = 1) => RemoveAt(0, count);
    public override ICollOps<T> RemoveLast(int count = 1) => RemoveAt(_items.Count() - count, count);
    public override ICollOps<T> RemoveAt(int index, int count = 1) {
        if (1 == count)
            _items.RemoveAt(index);
        else
            _items.RemoveRange(index, count);

        return this;
    }

    public override ICollOps<T> Remove(Predicate<T> match, out int num) {
        num = _items.RemoveAll(match);
        return this;
    }
}