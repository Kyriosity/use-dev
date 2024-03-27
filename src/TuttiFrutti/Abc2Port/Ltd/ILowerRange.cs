namespace Abc.Ltd;
public interface ILower<T> : IRestraint
{
    T Min { get; }
}
public interface ILowerRanged<T> : ILower<T>
{
    new T Min { get; init; }
}

public interface ILowerRangeable<T> : ILower<T>
{
    new T Min { get; set; }
}