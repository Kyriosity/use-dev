using ISie.Number.Is.Menu.TypeBreak;

namespace ISie.Number.Is;
public static partial class Go
{
    extension(decimal seed)
    {
        // IsCanonical always return true - no must to include it
        public IsFloatPtWithoutFraction Is => NotImplemented.Throw("under dev");
    }
}