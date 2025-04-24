using Abc.Char;
using Abc.Selection;

namespace ISie.Char.Is.Menus;

public interface IRoot :

    IAscii<IAscii>,

    IWhitespace<bool>, ISeparator<bool>, IPunctuation<bool>,

    ILetter<bool>, IDigit<bool>, ILetterOrDigit<bool>,

    ISymbol<bool>, IControl<bool>, ISurrogate<ILowHigh<bool>>,

    IBetween<char, bool>, ILowerUpper<bool>;


