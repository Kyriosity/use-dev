namespace Abc.Char;
public interface ISymbol<TRes>
{
    /// <summary>
    /// Symbol characters as `+`
    /// </summary>
    TRes Symbol { get; }
}
