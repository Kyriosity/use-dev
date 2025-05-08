namespace ISie.Char.Is.Menus;
internal abstract class DirectCalls<IO>(char seed) : Root<char, IO>(seed), IDirectCalls
    where IO : Circuitry.IO
{
    public bool Whitespace => Next<Fruit<char>>(char.IsWhiteSpace);

    public bool Separator => Next<Fruit<char>>(char.IsSeparator);

    public bool Punctuation => Next<Fruit<char>>(char.IsPunctuation);

    public bool Letter => Next<Fruit<char>>(char.IsLetter);

    public bool Digit => Next<Fruit<char>>(char.IsDigit);

    public bool LetterOrDigit => Next<Fruit<char>>(char.IsLetterOrDigit);

    public bool Symbol => Next<Fruit<char>>(char.IsSymbol);

    public bool Control => Next<Fruit<char>>(char.IsControl);

    public bool Lower => Next<Fruit<char>>(char.IsLower);

    public bool Upper => Next<Fruit<char>>(char.IsUpper);

    public bool Between(char minInclusive, char maxInclusive) =>
        Next<Fruit<char>>(ch => char.IsBetween(ch, minInclusive, maxInclusive));
}
