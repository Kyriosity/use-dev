using AbcDataOps.Text.Traits;

namespace AbcDataOps.ISie.Mk.blocks;
public interface StandardCode : ITruthValuing
{
    /// <summary>
    /// A-Z, a-z, 0-9, punctuation, control chars
    /// </summary>
    public RMedia Ascii { get; }
}

public interface IEndcodingWithGapOption : StandardCode, IGaps;