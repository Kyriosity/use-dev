namespace TestData.N_Val.Temperatures.Vals;
public static class Negative
{
    public static readonly (int K, int C, int F, int delta) Integer = (-727, -100, -1768, 1);

    public static readonly (double K, double C, double F, double delta) Precise = (-1234.567, -1507.717, -2681.8906, delta: 0.00000001);

    public static readonly (long K, long C, long F, long delta) Longest = (-512_4095_576_030_431_232, -512_4095_576_030_431_232, -9_223_372_036_854_775_807, delta: 1);
}

public static class Positive
{
    public static readonly (double K, double C, double F, double delta) Tiny = (0.000_000_000_001, 0.000_000_000_001, 0.000_000_000_001, 0.000_000_000_001);
    public static readonly (ulong K, ulong C, ulong F, ulong delta) Longest = (10248191152060862464, 10_248_191_152_060_862_464, 18_446_744_073_709_551_615, delta: 1);
}

public static class Zero
{
    public static readonly (double K, double C, double F, double delta) Kelvin = (0D, 0.00, 0.00, 0.00);
    public static readonly (double K, double C, double F, double delta) Celsius = (0.00, 0D, 0.00, 0.00);
    public static readonly (double K, double C, double F, double delta) Fahrenheit = (0.00, 0.00, 0D, 0.00);

}
