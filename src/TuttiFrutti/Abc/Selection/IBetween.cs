namespace Abc.Selection;
public interface IBetween<T, TRes>
{
    /// <summary>
    /// The range including its specified limits
    /// </summary>
    TRes Between(T minInclusive, T maxInclusive);
}
