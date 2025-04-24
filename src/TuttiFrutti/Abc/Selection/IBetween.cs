namespace Abc.Selection;
public interface IBetween<T, TRes>
{
    TRes Between(T minInclusive, T maxInclusive);
}
