using Abc.Logic.Circuitry.Bool;

namespace ISie.String;
public static class Go
{
    extension(string seed)
    {
        public ICultureNeutral Is => new Is.CultureNeutralMenu<IOWire>(seed);
        public ICultureNeutral Not => new Is.CultureNeutralMenu<IOInverter>(seed);

    }

    //public static ILingua Is<T>(this string value) where T : IScript, ISupported => null;

    //public static ILingua Is<T>(this string value) where T : INumber<T> => Encoding, Extended ASCIIs, ?Unicode;
}

