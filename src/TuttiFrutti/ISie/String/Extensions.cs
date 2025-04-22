namespace ISie.String;
public static class Extensions
{
    public static ICultureNeutral Is(this string value) => new Root.CultureNeutralMenu(value);
    //public static ILingua Is<T>(this string value) where T : INumber<T> => Encoding, Extended ASCIIs, ?Unicode;
    public static ILingua Is<T>(this string value) where T : IScript, ISupported => null;
}

// OTHER TYPES EXTENDABLE ! ? ToString() and Custom calls ?

