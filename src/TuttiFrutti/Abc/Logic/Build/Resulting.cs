namespace Abc.Logic.Build;
public abstract class Resulting<TRes> : IResultReady
{
    public static implicit operator TRes(Resulting<TRes> source) => source.Result();
    public abstract TRes Result();
}

public interface IResultReady;