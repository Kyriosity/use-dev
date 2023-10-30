using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Water
{
    public static ITemperature<double> TriplePoint => Build.Temperature.Const.All(0.01 + Gen.KelvinOffset, 0.01, 32.018);
    public static ITemperature<double> Boiling => Build.Temperature.Const.All(99.97 + Gen.KelvinOffset, 99.97, 211.946);
}
