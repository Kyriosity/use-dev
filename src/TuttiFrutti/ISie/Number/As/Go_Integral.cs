namespace ISie.Number.As;

public static partial class Go // +/- integral
{
    extension(sbyte seed)
    {
        public Mk.Root<sbyte> As => new(seed);
    }
    extension(byte seed)
    {
        public Mk.Root<byte> As => new(seed);
    }
    extension(int seed)
    {
        public Mk.Root<int> As => new(seed);
    }
    extension(uint seed)
    {
        public Mk.Root<uint> As => new(seed);
    }
    extension(long seed)
    {
        public Mk.Root<long> As => new(seed);
    }
    extension(ulong seed)
    {
        public Mk.Root<ulong> As => new(seed);
    }
}