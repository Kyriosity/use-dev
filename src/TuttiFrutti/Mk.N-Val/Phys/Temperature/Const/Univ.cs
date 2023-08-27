using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Univ
{
    public const double KminusC = 273.15;
    public static ITemp<double> AbsZero => Build.Temperature.Const(0d, -KminusC, -459.67);
}
