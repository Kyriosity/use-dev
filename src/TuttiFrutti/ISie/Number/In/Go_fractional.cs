namespace ISie.Number.In;
public static partial class Go
{
    extension(float seed)
    {
        public Mk.Root<float, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }

    extension(double seed)
    {
        public Mk.Root<double, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }

    extension(decimal seed)
    {
        public Mk.Root<decimal, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed);
    }

    extension(float? seed)
    {
        public Mk.Root<float, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }

    extension(double? seed)
    {
        public Mk.Root<double, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }

    extension(decimal? seed)
    {
        public Mk.Root<decimal, T> In<T>(IInclination? _ = null) where T : IScript, ISupported
            => new(seed.Value);
    }
}