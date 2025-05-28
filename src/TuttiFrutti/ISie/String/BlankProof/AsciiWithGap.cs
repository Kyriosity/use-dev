using ISie.Mk.Blocks;
using ISie.String.Traits;

namespace ISie.String.BlankProof;
public class AsciiWithGaps : Gaps, IAsciiWithGaps
{
    public Encoding Ascii => Next<Encoding>(seed => seed.NoNull().NoEmpty("can't check empty for encoding")
        .ToCharArray().All(ch => char.IsAscii(ch)));
}

public interface IAsciiWithGaps : IGaps
{
    /// <summary>
    /// Traits relevant to ASCII-128 set of characters
    /// </summary>
    Encoding Ascii { get; }
}