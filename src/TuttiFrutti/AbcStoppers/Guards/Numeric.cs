namespace AbcStoppers.Guards;
public static class Numeric
{
    extension<N>(N seed) where N : INumber<N>
    {
        public N NotOutRange(N low, N up) => seed;
    }
}