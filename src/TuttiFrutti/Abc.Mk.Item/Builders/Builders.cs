using Abc.Item;
using AbcExt.Errors.Sys;

namespace Abc.Mk.Item.Builders;

public class Item : IOutput
{
    public IGet<T> Of<T>(T value) => NotImplemented.Throw();

    public IGet<T> Of<T>(Func<T> init) => NotImplemented.Throw();
}

public class MaxItem<P, U> where P : IGet<U>
{
    public MaxItem(U max) { }

    public P Of<T>(T value) where T : U
        => NotImplemented.Throw();
}

public interface IOutput
{
    public IGet<T> Of<T>(T value);
    public IGet<T> Of<T>(Func<T> init); // Console.ReadKey; DateTime.Now
}

public interface IInitOutput : IOutput
{
    public new IInit<T> Of<T>(T value);

}

public interface IDoOutput : IOutput
{
    public new IInit<T> Of<T>(T value);

}

// class Item
// InitItem
//       Adjust
// MuteItem
// Adjust


public class GetItem
{
    public static IGet<T> Of<T>(T value) => NotImplemented.Throw();
}

public class Init
{
}

public class Set
{
    //public Buid<int> OnSet<X>(X value) => this;

}

public class Build<B>
{

    public Limited<B, L> Max<L>(L max) => new Limited<B, L>();
    public Limited<B, L> Min<L>(L min) => new Limited<B, L>();
    public Acted<B, F> Do<F>(F func) => new Acted<B, F>();
}

public class Limited<B, L> { }
public class Acted<B, F> { }
