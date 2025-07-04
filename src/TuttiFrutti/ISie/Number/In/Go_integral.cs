namespace ISie.Number.In;
/// <summary>
/// IMPORTANT: no extension for INumber since 1) `char` will get it, 2) generic parameter can't be specified implicitly
/// </summary>
public static partial class Go
{
    extension(sbyte seed)
    {
        public Mk.Root<sbyte, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }
    extension(short seed)
    {
        public Mk.Root<short, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }
    extension(int seed)
    {
        public Mk.Root<int, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }
    extension(long seed)
    {
        public Mk.Root<long, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }
    extension(nint seed)
    {
        public Mk.Root<nint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }

    extension(sbyte? seed)
    {
        public Mk.Root<sbyte, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
    extension(short? seed)
    {
        public Mk.Root<short, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
    extension(int? seed)
    {
        public Mk.Root<int, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
    extension(long? seed)
    {
        public Mk.Root<long, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
    extension(nint? seed)
    {
        public Mk.Root<nint, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
}