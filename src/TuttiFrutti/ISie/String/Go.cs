using Abc.Logic.Circuitry.Bool;

namespace ISie.String;
public static class Go
{
    public static ICultureNeutral Is(this string value) => new Is.CultureNeutralMenu<IOWire>(value);
    public static ICultureNeutral Not(this string value) => new Is.CultureNeutralMenu<IOInverter>(value);

    public static ILingua Is<T>(this string value) where T : IScript, ISupported => null;

    //public static ILingua Is<T>(this string value) where T : INumber<T> => Encoding, Extended ASCIIs, ?Unicode;
}

