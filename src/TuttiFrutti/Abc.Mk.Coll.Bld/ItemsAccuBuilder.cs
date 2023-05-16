using Abc.Coll;
using Abc.Coll.Gtor;

namespace Abc.Mk.Coll.Gtor;

public class ItemsAccuBuilder : IAdjustedItemsBuilder
{
    public IAdjustedItems<T> Of<T>() => new ListAccu<T>();

    public IAdjustedItems<T> Of<T>(T item) {
        var accu = new ListAccu<T>();
        accu.Add(item);
        return accu;
    }

    public IAdjustedItems<T> Of<T>(IEnumerable<T> items) {
        var accu = new ListAccu<T>();
        accu.Add(items);
        return accu;
    }

    public IAdjustedItems<T> Of<T>(params T[] items) {
        var accu = new ListAccu<T>();
        accu.Add(items);
        return accu;
    }
}
