namespace Abc.Char;
public interface IControl<TRes>
{
    /// <summary>
    /// Non-printable control characters
    /// </summary>
    TRes Control { get; }
}
