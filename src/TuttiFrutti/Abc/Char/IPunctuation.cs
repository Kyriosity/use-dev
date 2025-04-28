namespace Abc.Char;
public interface IPunctuation<TRes>
{
    /// <summary>
    /// Marks of punctuation in written texts (dot, comma, ...)
    /// </summary>
    TRes Punctuation { get; }
}
