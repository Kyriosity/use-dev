namespace AbcStoppers.Guards;
public static class GuardOutRange
{
    extension<N>(N seed) where N : INumber<N>
    {
        public N NotOutRange(N low, N top) => For(seed, low, top);
    }

    public static N For<N>(N val, N low, N top) where N : INumber<N> {
        ArgumentOutOfRangeException.ThrowIfLessThan(val, low);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(val, top);
        return val;
    }
}