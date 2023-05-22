using Abc.Coll;
using Abc.Coll.Gtor;

namespace Abc.Mk.Coll.Gtor;

public class PlainItemsAccuBuilder : AdjustedItemsBuilder<object>
{
    public ICollBuilder<R> OnSet<R>(Func<R, R> xlate) => new AdjustedItemsBuilder<R>(xlate);
}

public class AdjustedItemsBuilder<R> : ICollBuilder<R>
{
    private readonly Func<R, R> _onSet;
    public AdjustedItemsBuilder() : this(x => x) { }
    public AdjustedItemsBuilder(Func<R, R> onSet) { _onSet = onSet; }

    public IItemsAccu<T> Of<T>(IEnumerable<T> items) where T : R {
        var accu = FAccu<T>();
        accu.Add(items);
        return accu;
    }

    public IItemsAccu<T> Of<T>(params T[] items) where T : R {
        var listed = new List<T>();
        foreach (var item in items)
            listed.Add(item);
        return Of(listed);
    }

    public IItemsAccu<T> Of<T>(T item) where T : R => Of(new[] { item });

    protected virtual IAdjustedItems<T> FAccu<T>() where T : R => new ListAccu<T>() { OnSet = x => (T)_onSet(x) };
}
