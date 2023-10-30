using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Gen
{
    public const double KelvinOffset = 273.15;
    public static ITemperature<double> AbsZero => Build.Temperature.Const.All(0d, -KelvinOffset, -459.67);
}
