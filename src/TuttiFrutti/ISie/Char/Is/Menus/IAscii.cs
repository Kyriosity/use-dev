using Abc.Char;
using Abc.Selection;

namespace ISie.Char.Is.Menus;
public interface IAscii :

    IDigit<bool>, ILetterOrDigit<bool>,

    ILetter<ILowerUpper<bool>>,

    IHexDigit<ILowerUpper<bool>>;