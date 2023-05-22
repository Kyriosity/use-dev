namespace Abc.Xform;
public interface IAdjustedInput<T>
{
    Func<T, T> OnSet { get; }
}