using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Menu.TypeBreak;
public interface IsFloatPtWithoutFraction
{
    IIntegral Integer { get; } // ToDo: EXCLUDE Integer
    INatural NaturalOr0 { get; }
}
