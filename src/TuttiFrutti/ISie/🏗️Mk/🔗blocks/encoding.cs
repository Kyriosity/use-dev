using ISie.String.Traits;

namespace ISie.Mk.blocks;
public interface IStandardTextCode : ITruthValuing, IAscii<Encoding>;

public interface IEncodingWithGapOption : IStandardTextCode, IGaps;