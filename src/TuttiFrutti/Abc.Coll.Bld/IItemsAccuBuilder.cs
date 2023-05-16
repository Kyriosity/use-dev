namespace Abc.Coll.Gtor;

public interface IAdjustedItemsBuilder
{
    IAdjustedItems<T> Of<T>();
    IAdjustedItems<T> Of<T>(T item);
    IAdjustedItems<T> Of<T>(IEnumerable<T> items);
    IAdjustedItems<T> Of<T>(params T[] items);


}
