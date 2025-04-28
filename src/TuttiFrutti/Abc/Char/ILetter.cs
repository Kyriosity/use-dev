namespace Abc.Char;
public interface ILetter<TRes>
{
    /// <summary>
    /// Glyph of tongue alphabets (as 'A' for Latin and 'Λ' for Greek)
    /// </summary>
    TRes Letter { get; }
}
