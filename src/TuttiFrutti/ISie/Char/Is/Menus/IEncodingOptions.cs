using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;
public interface IEncodingOptions :

    IDigit<bool>, ILetterOrDigit<bool>,

    ILetter<LowerUpper>,

    IHexDigit<LowerUpper>;