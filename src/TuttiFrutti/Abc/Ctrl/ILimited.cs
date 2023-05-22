namespace Abc.Ctrl;
public interface ILimit<T> : IRestraint
{
    T Max { get; }
}

public interface ILimited<T> : ILimit<T>
{
    new int Max { get; init; }
}

public interface ILimitable<T> : ILimit<T>
{
    new int Max { get; set; }
}