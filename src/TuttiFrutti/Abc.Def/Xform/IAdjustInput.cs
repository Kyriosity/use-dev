namespace Abc.Xform;
public interface IAdjustedInput<T>
{
    Func<T, T> Xlate { get; }
}