using ISie.Char.Is.Menus;

namespace ISie.Char.Is.Blocks;
public class EncodingOptions : Fruit_And<char>, IEncodingOptions
{
    public bool Digit => Next<Fruit<char>>(char.IsDigit);

    public bool LetterOrDigit => Next<Fruit<char>>(char.IsLetterOrDigit);

    public LowerUpper Letter => Next<LowerUpper>(char.IsLetter);

    public LowerUpper HexDigit => Next<LowerUpper>(char.IsAsciiHexDigit);
}
