using Abc.Logic.Build;
using AbcDataOps.Text.Traits;

namespace AbcDataOps.ISie.Mk.blocks;
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
    /// E.g. "it is25inlay"
    /// </summary>
    bool WithoutNumberInlays { get; }
}

public abstract class Media : ConvertableToResult<bool>, IMedia, ITruthValuing
{
    public abstract bool AllPrintable { get; }
}