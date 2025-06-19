using AbcLingua.Rules;

namespace ISie.Number.In;
/// <summary>
/// IMPORTANT: no extension for INumber since 1) `char` will get it, 2) generic parameter can't be specified implicitly
/// </summary>
public static partial class Go
{
    public static InWords<sbyte, T> In<T>(this sbyte seed, IInclination? _ = null) where T : IScript, ISupported =>
        new InWords<sbyte, T>(seed);
    public static InWords<short, T> In<T>(this short seed, IInclination? _ = null) where T : IScript, ISupported =>
        new InWords<short, T>(seed);
    public static InWords<int, T> In<T>(this int seed, IInclination? _ = null) where T : IScript, ISupported =>
        new InWords<int, T>(seed);
    public static InWords<long, T> In<T>(this long seed, IInclination? _ = null) where T : IScript, ISupported =>
        new InWords<long, T>(seed);
    public static InWords<nint, T> In<T>(this nint seed, IInclination? _ = null) where T : IScript, ISupported =>
        new InWords<nint, T>(seed);

    public static InWords<sbyte, T> In<T>(this sbyte? seed, IInclination? _ = null) where T : IScript, ISupported =>
        In<T>((sbyte)seed.NoNull());
}


