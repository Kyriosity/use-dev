using ISie.Mk.blocks;
using ISie.String.BlankProof;

namespace ISie.String.Is;
internal class CultureNeutralMenu : RootMenu<string>, ICultureNeutral
{
    public CultureNeutralMenu(string seed) : base(seed) { }

    public bool NullOrEmpty => Next<Fruit<string>>(seed => seed is null or "");

    public IEncodingWithGapOption EmptyOr => Next<EncodingWithGap>(seed => seed.NotNull() is "");

    public IEncodingWithGapOption NullEmptyOr => Next<EncodingWithGap>(seed => seed is null or "");
    public bool Whitespace => Next<Fruit<string>>(seed => string.IsNullOrWhiteSpace(seed.NotNull().NotEmpty()));

    public bool SingleSpace => Next<Fruit<string>>(seed => seed is spaces.Single);

    public bool Spaces => Next<bool, Fruit<string>>(seed => seed.NotNull() is not "" &&
        seed.All(chr => ' ' == chr));

    public Encoding Ascii => Next<Encoding>(seed => seed.NotNull().NotEmpty("can't check empty for encoding")
        .ToCharArray().All(ch => char.IsAscii(ch)));
    public bool Grayspace => Next<Fruit<string>>(NotImplemented.Throw("reserved for discussions"));
}
