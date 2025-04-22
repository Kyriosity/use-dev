using ISie.Mk.blocks;
using ISie.String.BlankProof;

namespace ISie.String.Root;
internal class CultureNeutralMenu(string seed) : WizConstr.Core<string, bool>, ICultureNeutral
{
    public bool NullOrEmpty => Next<Ripe.Fruit<string>>(seed, string.IsNullOrEmpty);

    public IEncodingWithGapOption EmptyOr => Next<EmptyCheckMenu>(seed);

    public IEncodingWithGapOption NullEmptyOr => Next<NullEmptyCheckMenu>(seed);
    public bool Whitespace => Next<Ripe.Fruit<string>>(seed, Is.Whitespace);

    public bool SingleSpace => Next<Ripe.Fruit<string>>(seed, str => str is spaces.Single);

    public bool Spaces => Next<bool, Ripe.Fruit<string>>(seed, Is.Spaces);

    public Encoding Ascii => Next<Encoding>(seed);
    public bool Grayspace => Next<Ripe.Fruit<string>>(seed, Is.Grayspace);
}
