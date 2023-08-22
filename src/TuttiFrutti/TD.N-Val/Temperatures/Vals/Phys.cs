namespace TestData.N_Val.Temperatures.Vals;
public static class Phys
{
    public static readonly (double K, double C, double F, double delta) AbsZero = (0.00, -273.15, -459.67, 0.00000000001);

    // www.mpg.de/research/negative-absolute-temperature
    public static readonly (double K, double C, double F, double delta) AtomicGas = (-0.000000001, -273.150000001, -459.6700000018, 0.00000000001);

    public static readonly (ulong K, ulong C, ulong F, ulong delta) QuarkGluonPlasma_CERN2012 = (5_500_000_000_000, 5_499_999_999_727, 989_9999_999_540, 1);
}
