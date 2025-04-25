namespace Abc.Char.Blanks;

public interface IGrayspace<TRes>
{
    /// <summary>
    /// Whitespaces and punctuation (incl. underscore)
    /// SUBJECT of DISCUSSION: punctuation, controls, non-printable-s?
    /// </summary>
    TRes Grayspace { get; }
}
