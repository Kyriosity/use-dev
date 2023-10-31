using Mk.N_Val.Phys.Temperature.Const;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Wiring;
public static class UniLinears // KD, ToDo: move to func mdl!
{
    public static N C2K<N>(N x) where N : INumber<N> => x + N.CreateChecked(Gen.KelvinOffset);
    public static N K2C<N>(N x) where N : INumber<N> => x - N.CreateChecked(Gen.KelvinOffset);
    public static N F2C<N>(N from) where N : INumber<N> =>
        N.CreateChecked((double.CreateChecked(from) - 32) / 9 * 5);
    public static N C2F<N>(N from) where N : INumber<N> =>
        N.CreateChecked(double.CreateChecked(from) / 5 * 9) + N.CreateChecked(32);

    public static N F2K<N>(N from) where N : INumber<N> => N.CreateChecked(
        (double.CreateChecked(from) - 32) / 9 * 5) + N.CreateChecked(Gen.KelvinOffset);
    public static N K2F<N>(N from) where N : INumber<N> =>
        N.CreateChecked((double.CreateChecked(from) - Gen.KelvinOffset) / 5 * 9) + N.CreateChecked(32);
}
