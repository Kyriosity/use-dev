namespace Abc.Char;
public interface IAscii<TRes>
{
    /// <summary>
    /// A-Z, a-z, 0-9, punctuation, control chars
    /// </summary>
    TRes Ascii { get; }
}
