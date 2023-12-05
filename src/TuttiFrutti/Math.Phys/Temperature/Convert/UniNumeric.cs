using System.Numerics;

namespace Math.Phys.Temperature.Convert;

public static class UniNumeric
{
    public static N C2K<N>(N x) where N : INumber<N> => x + N.CreateChecked(Diff.KelvinCelsius);
    public static N K2C<N>(N x) where N : INumber<N> => x - N.CreateChecked(Diff.KelvinCelsius);
    public static N F2C<N>(N from) where N : INumber<N> =>
        N.CreateChecked((double.CreateChecked(from) - 32) / 9 * 5);
    public static N C2F<N>(N from) where N : INumber<N> =>
        N.CreateChecked(double.CreateChecked(from) / 5 * 9) + N.CreateChecked(32);

    public static N F2K<N>(N from) where N : INumber<N> => N.CreateChecked(
        (double.CreateChecked(from) - 32) / 9 * 5) + N.CreateChecked(Diff.KelvinCelsius);
    public static N K2F<N>(N from) where N : INumber<N> =>
        N.CreateChecked((double.CreateChecked(from) - Diff.KelvinCelsius) / 5 * 9) + N.CreateChecked(32);
}
