namespace Abc.Coll.Gtor;
public interface ICollBuilder<R>
{
    IItemsAccu<T> Of<T>(params T[] items) where T : R;
    IItemsAccu<T> Of<T>(T item) where T : R;
    IItemsAccu<T> Of<T>(IEnumerable<T> items) where T : R;
}
