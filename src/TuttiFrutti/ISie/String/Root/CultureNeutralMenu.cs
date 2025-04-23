using ISie.Mk.blocks;
using ISie.String.BlankProof;

namespace ISie.String.Root;
internal class CultureNeutralMenu : WizConstr.Core<string, bool>, ICultureNeutral
{
    public CultureNeutralMenu(string seed) {
        Seed = seed;
    }

    public bool NullOrEmpty => Next<Ripe.Fruit<string>>(string.IsNullOrEmpty);

    public IEncodingWithGapOption EmptyOr => Next<EmptyCheckMenu>();

    public IEncodingWithGapOption NullEmptyOr => Next<NullEmptyCheckMenu>();
    public bool Whitespace => Next<Ripe.Fruit<string>>(Is.Whitespace);

    public bool SingleSpace => Next<Ripe.Fruit<string>>(str => str is spaces.Single);

    public bool Spaces => Next<bool, Ripe.Fruit<string>>(Is.Spaces);

    public Encoding Ascii => Next<Encoding>();
    public bool Grayspace => Next<Ripe.Fruit<string>>(Is.Grayspace);
}
