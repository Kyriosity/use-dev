namespace AbcDataOps.Text.Traits;
public interface IGaps
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace#remarks">Whitespaces list</seealso> 
    /// </summary>
    bool Whitespace { get; }
    /// <summary>
    /// Whitespaces and punctuation (incl. underscore)
    /// </summary>
    bool Grayspace { get; }

    bool SingleSpace { get; }
    bool Spaces { get; }
}
