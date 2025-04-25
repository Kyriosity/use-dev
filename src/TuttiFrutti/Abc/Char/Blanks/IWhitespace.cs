namespace Abc.Char.Blanks;

/// <summary>
/// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace#remarks">Whitespaces list</seealso> 
/// </summary>
public interface IWhitespace<TRes>
{
    TRes Whitespace { get; }
}
