using Abc.Err.Sys;
using Abc.Item;

namespace Abc.Mk.Item.Builders;

public class Item : IOutput
{
    public IProped<T> Of<T>(T value) => NotImplemented.Throw();

    public MaxItem<U> Max<U>(U max) => new(max);

    public IProped<T> Of<T>(Func<T> init) => NotImplemented.Throw();
}

public class MaxItem<U>
{
    public MaxItem(U max) { }

    public IMaxItem<T> Of<T>(T value) where T : U
        => NotImplemented.Throw();
}

public interface IOutput
{
    public IProped<T> Of<T>(T value);
    public IProped<T> Of<T>(Func<T> init); // Console.ReadKey; DateTime.Now

}


