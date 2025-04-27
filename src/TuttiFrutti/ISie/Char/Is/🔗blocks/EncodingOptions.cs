using ISie.Char.Is.Menus;

namespace ISie.Char.Is.Blocks;
public class EncodingOptions : Fruit_And<char>, IEncodingOptions
{
    public bool Digit => char.IsDigit(Seed);

    public bool LetterOrDigit => char.IsLetterOrDigit(Seed);

    public LowerUpper Letter => Next<LowerUpper>(char.IsLetter);

    public LowerUpper HexDigit => Next<LowerUpper>(char.IsAsciiHexDigit);
}
