using ISie.Mk.Blocks;
using ISie.String.BlankProof;

namespace ISie.String.Is;
internal class CultureNeutralMenu<IO>(string seed) : Root<string, IO>(seed), ICultureNeutral
    where IO : Circuitry.IO
{
    public bool NullOrEmpty => Next<Fruit<string>>(seed => seed is null or "");

    public AsciiWithGaps EmptyOr => Next<AsciiWithGaps>(seed => seed.NoNull() is "");

    public AsciiWithGaps NullEmptyOr => Next<AsciiWithGaps>(seed => seed is null or "");
    public bool Whitespace => Next<Fruit<string>>(seed => string.IsNullOrWhiteSpace(seed.NoNull()) && seed is not "");

    public bool SingleSpace => Next<Fruit<string>>(seed => seed.NoNull() is spaces.Single);

    public bool Spaces => Next<Fruit<string>>(seed => seed.NoNull() is not "" &&
        seed.All(chr => ' ' == chr));

    public Encoding Ascii => Next<Encoding>(seed => seed.NoNull().NoEmpty("can't check empty for encoding")
        .ToCharArray().All(ch => char.IsAscii(ch)));
    public bool Grayspace => Next<Fruit<string>>(NotImplemented.Throw("reserved for discussions"));
}
