namespace Abc.Char;
public interface ILetterOrDigit<TRes>
{
    /// <summary>
    /// Alphanumeric: ten Arabic numbers (0-9) and glyphs of human tongues (as 'A' for Latin and 'Λ' for Greek)
    /// </summary>
    TRes LetterOrDigit { get; }
}
