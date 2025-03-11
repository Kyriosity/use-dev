using ISie.String.Traits;

namespace ISie.Mk.blocks;
public interface ITextual<LTR, TXT>
{
    LTR Letters { get; }
    LTR Alphanumeric { get; }

    /// <summary>
    /// Includes 
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

public class RMedia(string seed) : boolBlocks.Fruit<string>(seed), IMedia
{

    public bool AllPrintable => false; // Next<>(); ToDo: // BUILT IN FUNC SUPPLIED 


    protected override bool Eval() =>
        string.Empty != seed && seed.ToCharArray().Any(ch => !char.IsAscii(ch));
}