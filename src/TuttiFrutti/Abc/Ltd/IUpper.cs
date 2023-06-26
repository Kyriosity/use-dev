namespace Abc.Ltd;
public interface IUpper<T> : IRestraint
{
    T Max { get; }
}

public interface IUpperRanged<T> : IUpper<T>
{
    new int Max { get; init; }
}

public interface IUpperRangeable<T> : IUpper<T>
{
    new int Max { get; set; }
}