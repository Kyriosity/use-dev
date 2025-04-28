namespace Abc.Char;
public interface IAscii<TRes>
{
    /// <summary>
    /// Classic 7-bit encoding: A-Z, a-z, 0-9, punctuation, control chars. See also:
    /// <seealso href = "https://www.ascii-code.com/">ASCII table</seealso>
    /// </summary>
    TRes Ascii { get; }
}
