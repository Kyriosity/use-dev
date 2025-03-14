using ISie.String.Traits;

namespace ISie.Mk.blocks;
public interface IStandardTextCode : ITruthValuing
{
    /// <summary>
    /// A-Z, a-z, 0-9, punctuation, control chars
    /// </summary>
    public Encoding Ascii { get; }
}

public interface IEndcodingWithGapOption : IStandardTextCode, IGaps;