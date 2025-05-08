namespace ISie.Char.Is.Menus;
internal abstract class DirectCalls<IO>(char seed) : Root<char, IO>(seed), IDirectCalls
    where IO : Circuitry.IO
{
    public bool Whitespace => Next(char.IsWhiteSpace);

    public bool Separator => Next(char.IsSeparator);

    public bool Punctuation => Next(char.IsPunctuation);

    public bool Letter => Next(char.IsLetter);

    public bool Digit => Next(char.IsDigit);

    public bool LetterOrDigit => Next(char.IsLetterOrDigit);

    public bool Symbol => Next(char.IsSymbol);

    public bool Control => Next(char.IsControl);

    public bool Lower => Next(char.IsLower);

    public bool Upper => Next(char.IsUpper);

    public bool Between(char minInclusive, char maxInclusive) => Next(ch => char.IsBetween(ch, minInclusive, maxInclusive));
}
