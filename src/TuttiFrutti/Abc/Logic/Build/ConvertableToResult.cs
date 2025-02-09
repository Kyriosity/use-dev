namespace Abc.Logic.Build;
public abstract class ConvertableToResult<T> : IResultReady
{
    public static implicit operator T(ConvertableToResult<T> source) =>
        throw new NotImplementedException($"{source.GetType().FullName} to {typeof(T).FullName}");
}

public interface IResultReady;