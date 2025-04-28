namespace Abc.Char;
public interface IHexDigit<TRes>
{
    /// <summary>
    /// Representing 16-base numbers from 0-9 and a-f (A-F)
    /// </summary>
    TRes HexDigit { get; }
}
