namespace Abc.Ltd;
public interface ILowerLimit<T> : ILimit
{
    T Min { get; }
}
public interface ILowerLimited<T> : ILowerLimit<T>
{
    new T Min { get; init; }
}

public interface ILowerLimitable<T> : ILowerLimit<T>
{
    new T Min { get; set; }
}