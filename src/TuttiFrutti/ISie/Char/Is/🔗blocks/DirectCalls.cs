namespace ISie.Char.Is.Menus;
internal abstract class DirectCalls : RootMenu<char>, IDirectCalls
{
    internal DirectCalls(char seed) : base(seed) { }

    public bool Whitespace => char.IsWhiteSpace(Seed);

    public bool Separator => char.IsSeparator(Seed);

    public bool Punctuation => char.IsPunctuation(Seed);

    public bool Letter => char.IsLetter(Seed);

    public bool Digit => char.IsDigit(Seed);

    public bool LetterOrDigit => char.IsLetterOrDigit(Seed);

    public bool Symbol => char.IsSymbol(Seed);

    public bool Control => char.IsControl(Seed);

    public bool Lower => char.IsLower(Seed);

    public bool Upper => char.IsUpper(Seed);

    public bool Between(char minInclusive, char maxInclusive) => char.IsBetween(Seed, minInclusive, maxInclusive);
}
