using ISie.Mk.Blocks;
using ISie.String.Traits;

namespace ISie.String.BlankProof;
public class AsciiWithGaps : Gaps, IAsciiWithGaps
{
    public Encoding Ascii => Next<Encoding>();
}

public interface IAsciiWithGaps : IGaps
{
    Encoding Ascii { get; }
}