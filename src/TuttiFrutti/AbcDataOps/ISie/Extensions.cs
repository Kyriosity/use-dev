
using AbcDataOps.ISie.Mk;

namespace AbcDataOps.ISie;
public static class Extensions
{
    public static ICultureNeutral Is(this string val) => null;
    public static ILingua Is<T>(this string val) where T : IScript, ISupported
        => null;
}

// OTHER TYPES EXTANDABLE ! ? ToString() and Custom calls ?

public static class space
{
    public const string Single = " ";
}