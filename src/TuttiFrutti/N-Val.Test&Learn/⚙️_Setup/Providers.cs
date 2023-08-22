using Mk.N_Val.Phys.Temperature.Build;
using TestData.N_Val.Temperatures.Vals;

namespace N_Val.Test_Learn.Setup;
public static class Providers
{
    public readonly static object[] MutitypeNumerics = {
        Temperature.Celsius(Water.Boiling.C),
        Temperature.Fahrenheit(Water.Boiling.F),
        Temperature.Fahrenheit(Cosmo.SunSurface.K),
    };
}
