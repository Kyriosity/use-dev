namespace Abc.Char.Blanks;
public interface IEmpty<TRes>
{
    /// <summary>
    /// No item but not null
    /// </summary>
    TRes Empty { get; }
}
