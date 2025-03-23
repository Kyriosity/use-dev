using ISie.Mk;
using ISie.Mk.blocks;
using ISie.String.BlankProof;

namespace ISie.String.Root;
internal class CultureNeutralMenu(string seed) : Root<string, bool>, ICultureNeutral
{
    public bool NullOrEmpty =>
        Plant<Wiz.Ripe.End.Fruit<string>>(seed, string.IsNullOrEmpty);

    public IEncodingWithGapOption EmptyOr => Plant<EmptyCheckMenu>(seed);

    public IEncodingWithGapOption NullEmptyOr => Plant<NullEmptyCheckMenu>(seed);
    public bool Whitespace =>
        Plant<Wiz.Ripe.End.Fruit<string>>(seed, Is.Whitespace);

    public bool SingleSpace => Plant<Wiz.Ripe.End.Fruit<string>>(seed, str => str is spaces.Single);

    public bool Spaces => Plant<Wiz.Ripe.End.Fruit<string>>(seed, Is.Spaces);

    public Encoding Ascii => Plant<Encoding>(seed);
    public bool Grayspace =>
        Plant<Wiz.Ripe.End.Fruit<string>>(seed, Is.Grayspace);
}
