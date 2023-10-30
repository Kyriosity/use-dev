using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Boiling
{
    public static ITemperature<double> Hydrogen => Build.Temperature.Const.All(H_C + Gen.KelvinOffset, H_C, -423.1822);
    public static ITemperature<double> Helium => Build.Temperature.Const.All(He_C + Gen.KelvinOffset, He_C, -452.0704);
    public static ITemperature<double> Nitrogen => Build.Temperature.Const.All(77.355, -195.795, -320.431);

    private const double H_C = -252.879;
    private const double He_C = -268.928;
}
