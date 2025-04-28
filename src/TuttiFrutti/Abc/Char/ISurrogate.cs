namespace Abc.Char;
public interface ISurrogate<TRes>
{
    /// <summary>
    ///  UTF-16 code unit in the range from U+D800 to U+DFFF
    /// </summary>
    TRes Surrogate { get; }
}
