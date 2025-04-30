using ISie.Mk.Blocks;
using ISie.String.BlankProof;

namespace ISie.String.Is;
internal class CultureNeutralMenu(string seed) : Root<string>(seed), ICultureNeutral
{
    public bool NullOrEmpty => Next<Fruit<string>>(seed => seed is null or "");

    public AsciiWithGaps EmptyOr => Next<AsciiWithGaps>(seed => seed.NotNull() is "");

    public AsciiWithGaps NullEmptyOr => Next<AsciiWithGaps>(seed => seed is null or "");
    public bool Whitespace => Next<Fruit<string>>(seed => string.IsNullOrWhiteSpace(seed.NotNull()) && seed is not "");

    public bool SingleSpace => Next<Fruit<string>>(seed => seed.NotNull() is spaces.Single);

    public bool Spaces => Next<bool, Fruit<string>>(seed => seed.NotNull() is not "" &&
        seed.All(chr => ' ' == chr));

    public Encoding Ascii => Next<Encoding>(seed => seed.NotNull().NotEmpty("can't check empty for encoding")
        .ToCharArray().All(ch => char.IsAscii(ch)));
    public bool Grayspace => Next<Fruit<string>>(NotImplemented.Throw("reserved for discussions"));
}
