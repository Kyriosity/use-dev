using Abc.Coll;

namespace Abc.Mk.Coll;

public abstract class AccuOnColl<T, C> : IAdjustedItems<T> where C : ICollection<T>, new()
{
    protected C _items = new();

    public Func<T, T> OnSet { get; init; } = x => x;

    public abstract ICollOps<T> RemoveFirst(int count = 1);
    public abstract ICollOps<T> RemoveLast(int count = 1);
    public abstract ICollOps<T> RemoveAt(int index, int count = 1);

    public virtual ICollOps<T> Remove(Predicate<T> match) => Remove(match, out int _);

    public virtual ICollOps<T> Remove(Predicate<T> match, out int num) {
        var remain = _items.Where(item => !match(item)).ToList();
        num = _items.Count - remain.Count;
        if (0 < num) {
            RemoveFirst(_items.Count);
            Add(remain);
        }

        return this;
    }

    public abstract T this[int index] { get; }

    public virtual IReadOnlyCollection<T> Items => (IReadOnlyCollection<T>)_items;

    public virtual ICollOps<T> Add(IEnumerable<T> items) {
        foreach (var item in items)
            _items.Add(item);

        return this;
    }

    public virtual ICollOps<T> Add(T first, params T[] rest) {
        _items.Add(first);
        foreach (var item in rest)
            _items.Add(item);

        return this;
    }
}
