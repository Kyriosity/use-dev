using AbcDataOps.Text.Traits;

namespace AbcDataOps.ISie.Mk.blocks;
public interface IStandardTextCode : ITruthValuing
{
    /// <summary>
    /// A-Z, a-z, 0-9, punctuation, control chars
    /// </summary>
    public RMedia Ascii { get; }
}

public interface IEndcodingWithGapOption : IStandardTextCode, IGaps;