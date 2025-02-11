using AbcDataOps.Text.Traits;

namespace AbcDataOps.ISie.Mk.blocks;
public interface IEncodingOptions : ITruthValuing
{
    /// <summary>
    /// ASCII symbols
    /// </summary>
    Media Ascii { get; }
}

public interface IEndcodingWithGapOption : IEncodingOptions, IGaps;