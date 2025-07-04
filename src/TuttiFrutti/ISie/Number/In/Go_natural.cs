namespace ISie.Number.In;
public static partial class Go
{
    extension(byte seed)
    {
        public Mk.Root<byte, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed);
    }
    extension(ushort seed)
    {
        public Mk.Root<ushort, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed);
    }
    extension(uint seed)
    {
        public Mk.Root<uint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed);
    }
    extension(ulong seed)
    {
        public Mk.Root<ulong, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed);
    }
    extension(nuint seed)
    {
        public Mk.Root<nuint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed);
    }

    extension(byte? seed)
    {
        public Mk.Root<byte, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed.Value);
    }
    extension(ushort? seed)
    {
        public Mk.Root<ushort, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed.Value);
    }
    extension(uint? seed)
    {
        public Mk.Root<uint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed.Value);
    }
    extension(ulong? seed)
    {
        public Mk.Root<ulong, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed.Value);
    }
    extension(nuint? seed)
    {
        public Mk.Root<nuint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported => new(seed.Value);
    }
}
