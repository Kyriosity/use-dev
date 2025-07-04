using ISie.Mk.Blocks;
using ISie.String.BlankProof;

namespace ISie.String.Is;
internal class CultureNeutralMenu<IO>(string seed) : Root<string, IO>(seed), ICultureNeutral
    where IO : Circuitry.IO
{
    public bool NullOrEmpty => Next(seed => seed is null or "");

    public AsciiWithGaps EmptyOr => Next<AsciiWithGaps>(seed => seed.NoNull is "");

    public AsciiWithGaps NullEmptyOr => Next<AsciiWithGaps>(seed => seed is null or "");
    public bool Whitespace => Next(seed => string.IsNullOrWhiteSpace(seed.NoNull) && seed is not "");

    public bool SingleSpace => Next(seed => seed.NoNull is spaces.Single);

    public bool Spaces => Next(seed => seed.NoNull is not "" && seed.All(chr => ' ' == chr));

    public Encoding Ascii => Next<Encoding>(seed => seed.NoNull.NoEmpty
        .ToCharArray().All(ch => char.IsAscii(ch)));
    public bool Grayspace => NotImplemented.Throw("reserved for experimental feature (TBD)");
}
