using AbcLingua.Rules;

namespace ISie.Number.In;
public static partial class Go
{
    public static Mk.Root<byte, T> In<T>(this byte seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<ushort, T> In<T>(this ushort seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<uint, T> In<T>(this uint seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<ulong, T> In<T>(this ulong seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<nuint, T> In<T>(this nuint seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed);
    public static Mk.Root<byte, T> In<T>(this byte? seed, IInclination? _ = null)
    where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<ushort, T> In<T>(this ushort? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<uint, T> In<T>(this uint? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<ulong, T> In<T>(this ulong? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
    public static Mk.Root<nuint, T> In<T>(this nuint? seed, IInclination? _ = null)
        where T : IScript, ISupported => new(seed.Value);
}
