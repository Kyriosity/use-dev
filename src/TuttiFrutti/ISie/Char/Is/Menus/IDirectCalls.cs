namespace ISie.Char.Is.Menus;
public interface IDirectCalls :
    IWhitespace<bool>, ISeparator<bool>, IPunctuation<bool>,

    ILetter<bool>, IDigit<bool>, ILetterOrDigit<bool>,

    ISymbol<bool>, IControl<bool>,

    IBetween<char, bool>, ILowerUpper<bool>;
