using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Melting
{
    public static ITemperature<double> Iron => Build.Temperature.Const.All(1811.15, 1_538, 2_800.4);
    public static ITemperature<double> Quicksilver => Build.Temperature.Const.All(234.32, -38.83, -37.894);
    public static ITemperature<double> Silver => Build.Temperature.Const.All(1_234.93, 961.78, 1_763.204);
    public static ITemperature<double> Gold => Build.Temperature.Const.All(1_337.33, 1_064.18, 1_947.52);
    public static ITemperature<double> Platinum => Build.Temperature.Const.All(Pt_C + Gen.KelvinOffset, Pt_C, 3_214.94);
    public static ITemperature<double> Tungsten => Build.Temperature.Const.All(Pt_W + Gen.KelvinOffset, Pt_W, 6_191.6);

    private const double Pt_C = 1_768.3;
    private const double Pt_W = 3_422.00;
}

