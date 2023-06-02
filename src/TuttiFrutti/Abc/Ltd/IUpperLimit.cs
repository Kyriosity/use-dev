namespace Abc.Ltd;
public interface IUpperLimit<T> : ILimit
{
    T Max { get; }
}

public interface IUpperLimited<T> : IUpperLimit<T>
{
    new int Max { get; init; }
}

public interface IUpperLimitable<T> : IUpperLimit<T>
{
    new int Max { get; set; }
}