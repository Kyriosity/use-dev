namespace Abc.Char.Blanks;

public interface IWhitespace<TRes>
{
    /// <summary>
    /// Whitespace characters according to Microsoft 
    /// <seealso href = "https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace#remarks"> Whitespaces list</seealso>
    /// </summary>
    TRes Whitespace { get; }
}
