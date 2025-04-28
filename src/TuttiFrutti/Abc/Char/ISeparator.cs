namespace Abc.Char;
public interface ISeparator<TRes>
{
    /// <summary>
    /// Three categories of separators. See 
    /// <seealso href = "https://learn.microsoft.com/en-us/dotnet/api/system.char.isseparator" >Microsoft explanation</seealso>
    /// </summary>
    TRes Separator { get; }
}
