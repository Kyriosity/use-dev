namespace ISie.Number.As;

public static partial class Go // +/- integral
{
    extension(sbyte seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<sbyte> As => new(seed);
    }

    extension(byte seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<byte> As => new(seed);
    }

    extension(int seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<int> As => new(seed);
    }

    extension(uint seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<uint> As => new(seed);
    }

    extension(long seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<long> As => new(seed);
    }

    extension(ulong seed)
    {
        /// <summary>
        /// Represents numbers 1-3'999 as Roman or throws OutOfRange 
        /// </summary>
        public Mk.Root<ulong> As => new(seed);
    }
}