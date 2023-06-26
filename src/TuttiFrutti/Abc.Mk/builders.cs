using Abc.Err.Sys;
using Abc.Ltd;
using Abc.Prop;

namespace Abc.Mk;
public class FullItem
{
    public Item<T> Limit<T>(T limit) => NotImplemented.Throw();
    //public Item Adjust<T>() => NotImplemented.Throw();
}

public class Item<T> : IUpper<T>
{
    public T Max => NotImplemented.Throw();

    public IItem<T> Of<T>() => NotImplemented.Throw();
}


interface IRangeItem<T> : IItem<T>
{

}

interface IActedItem<T> : IItem<T>
{

}