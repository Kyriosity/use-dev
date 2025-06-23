namespace ISie.Number.In;
/// <summary>
/// IMPORTANT: no extension for INumber since 1) `char` will get it, 2) generic parameter can't be specified implicitly
/// </summary>
public static partial class Go
{
    public static Mk.Root<sbyte, T> In<T>(this sbyte seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<short, T> In<T>(this short seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<int, T> In<T>(this int seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<long, T> In<T>(this long seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<nint, T> In<T>(this nint seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);

    public static Mk.Root<sbyte, T> In<T>(this sbyte? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<short, T> In<T>(this short? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<int, T> In<T>(this int? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<long, T> In<T>(this long? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<nint, T> In<T>(this nint? seed, IInclination? _ = null)
        where T : IScript, ISupported => In<T>(seed.Value);
}