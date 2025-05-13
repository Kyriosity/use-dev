namespace ISie.Number.Is.Menu.Options;
public interface INatural : IIntegral
{
    /// <summary>
    /// The number is 2 powered by any whole-number exponent: 1, 2, 4, 8, 16, ...
    /// </summary>
    bool PowOf2 { get; }
}
