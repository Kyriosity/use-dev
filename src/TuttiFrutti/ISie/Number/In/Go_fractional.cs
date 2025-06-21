using AbcLingua.Rules;

namespace ISie.Number.In;
public static partial class Go
{
    public static Mk.Root<float, T> In<T>(this float seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<double, T> In<T>(this double seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<decimal, T> In<T>(this decimal seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<float, T> In<T>(this float? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<double, T> In<T>(this double? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<decimal, T> In<T>(this decimal? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
}