using AbcCommu.Errors.Sys;
using ISie.Mk.blocks;
using ISie.String.BlankProof;

namespace ISie.String.Root;
internal class CultureNeutralMenu : RootMenu<string>, ICultureNeutral
{
    public CultureNeutralMenu(string seed) : base(seed) { }

    public bool NullOrEmpty => Next<Fruit<string>>(string.IsNullOrEmpty);

    public IEncodingWithGapOption EmptyOr => Next<EncodingWithGap>(seed => seed is null ?
      NullReference.Throw("initial value (seed) is null") : seed is "");

    public IEncodingWithGapOption NullEmptyOr => Next<EncodingWithGap>(seed => seed is "");
    public bool Whitespace => Next<Fruit<string>>(Is.Whitespace);

    public bool SingleSpace => Next<Fruit<string>>(str => str is spaces.Single);

    public bool Spaces => Next<bool, Fruit<string>>(Is.Spaces);

    public Encoding Ascii => Next<Encoding>();
    public bool Grayspace => Next<Fruit<string>>(Is.Grayspace);
}
