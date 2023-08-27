using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Boiling
{

    public static ITemp<double> Hydrogen => Build.Temperature.Const(H_C + Univ.KminusC, H_C, -423.1822);
    public static ITemp<double> Helium => Build.Temperature.Const(He_C + Univ.KminusC, He_C, -452.0704);
    public static ITemp<double> Nitrogen => Build.Temperature.Const(77.355, -195.795, -320.431);

    private const double H_C = -252.879;
    private const double He_C = -268.928;
}
