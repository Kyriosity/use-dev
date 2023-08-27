using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Water
{
    public static ITemp<double> TriplePoint => Build.Temperature.Const(0.01 + Univ.KminusC, 0.01, 32.018);
    public static ITemp<double> Boiling => Build.Temperature.Const(99.97 + Univ.KminusC, 99.97, 211.946);
}
