using ISie.String.Traits;

namespace ISie.Mk.Blocks;
public interface ITextual<LTR, TXT>
{
    /// <summary>
    /// Only letter glyphs of known alphabets
    /// </summary>
    LTR Letters { get; }

    /// <summary>
    /// Letters of known alphabets and characters 0-9
    /// </summary>
    LTR Alphanumeric { get; }

    /// <summary>
    /// Alphabet constructions, which includes punctuation and separators
    /// </summary>
    TXT Text { get; }
}

public interface IExtraSpace
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace#remarks">Whitespaces list</seealso> 
    /// </summary>
    bool AllowWhitespace { get; }
}

public interface IExtraText : ITextCheck
{
    /// <summary>
    /// Misc. brackets and quotes, «..»» „..” °  _ / \ * + % №  Nº  
    /// </summary>
    ITextCheck AllowMiscSymbols { get; }
}

public interface ITextCheck
{
    /// <summary>
    /// E.g. "it is123inlay"
    /// </summary>
    bool WithoutNumberInlays { get; }
}

public class Encoding : Fruit<string>, IEncodingChecks
{

    /// <summary>
    /// Contains no control characters
    /// </summary>
    public bool NoControls => And(seed => seed.NoEmpty.
        ToCharArray().All(ch => !char.IsControl(ch)));
}