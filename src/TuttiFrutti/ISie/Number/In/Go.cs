using AbcLingua.Rules;
using System.Numerics;

namespace ISie.Number.In;
/// <summary>
/// IMPORTANT: no extension for INumber since 1) `char` will get it, 2) generic parameter can't be specified implicitly
/// </summary>
public static partial class Integral_Signed
{
    public static string In<T>(this sbyte seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this short seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this int seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this long seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this nint seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);

}

public static partial class Integral_Signed
{
    public static string In<T>(this sbyte? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((sbyte)seed.NoNull()).In<T>();
    public static string In<T>(this short? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((short)seed.NoNull()).In<T>();
    public static string In<T>(this int? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((int)seed.NoNull()).In<T>();
    public static string In<T>(this long? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((long)seed.NoNull()).In<T>();
    public static string In<T>(this nint? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((nint)seed.NoNull()).In<T>();
}

public static partial class Integral_Unsigned
{
    public static string In<T>(this byte seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this ushort seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this uint seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this ulong seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
    public static string In<T>(this nuint seed, IInclination? _ = null) where T : IScript, ISupported => Hub<T>.In(seed);
}
public static partial class Integral_Unsigned
{
    public static string In<T>(this byte? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((byte)seed.NoNull()).In<T>();
    public static string In<T>(this ushort? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((ushort)seed.NoNull()).In<T>();
    public static string In<T>(this uint? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((uint)seed.NoNull()).In<T>();
    public static string In<T>(this ulong? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((ulong)seed.NoNull()).In<T>();
    public static string In<T>(this nuint? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((nuint)seed.NoNull()).In<T>();
}

public static class FloatingPoint
{
    public static string In<T>(this float seed, IInclination? _ = null) where T : IScript, ISupported
        => Hub<T>.In(seed);

    public static string In<T>(this double seed, IInclination? _ = null) where T : IScript, ISupported
    => Hub<T>.In(seed);

    public static string In<T>(this decimal seed, IInclination? _ = null) where T : IScript, ISupported
        => Hub<T>.In(seed);
    public static string In<T>(this float? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((float)seed.NoNull()).In<T>();

    public static string In<T>(this double? seed, IInclination? _ = null) where T : IScript, ISupported
        => ((double)seed.NoNull()).In<T>();

    public static string In<T>(this decimal? seed, IInclination? inclination = null) where T : IScript, ISupported
        => ((decimal)seed.NoNull()).In<T>();
}

static class Hub<T>
{
    internal static string In<N>(N seed) where N : INumber<N> => NotImplemented.Throw("under construction");
}

