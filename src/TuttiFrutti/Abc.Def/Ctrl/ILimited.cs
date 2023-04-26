namespace Abc.Ctrl;
public interface ILimited : IRestraint
{
    int Max { get; }
}

public interface ILimitable : ILimited
{
    new int Max { get; set; }
}