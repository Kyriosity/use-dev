namespace ISie.String.Traits;

public interface IEncodingChecks
{
    /// <summary>
    /// Contains no control characters
    /// </summary>
    bool NoControls { get; }
}