namespace TestData.N_Val.Temperatures.Vals;
public static class Negative
{
    public static readonly (int K, int C, int F, int delta) Integer = (-100, -373, -640, 1);

    public static readonly (double K, double C, double F, double delta) Precise = (-1234.567, -1507.717, -2681.8906, delta: 0.00000001);


    public static readonly (long K, long C, long F, long delta) HugeWhole = (-4_999_999_999_999_999_727, -5_000_000_000_000_000_000, -9_000_000_000_000_000_000 + 32, delta: 1);

    public static readonly (long K, long C, long F, long delta) Longest = (-5_124_095_576_030_430_959, -5_124_095_576_030_431_232, -9_223_372_036_854_775_807, delta: 1);

}

public static class Positive
{
    public static readonly (double K, double C, double F, double delta) Tiny = (0.000_000_000_743, -273.149999999257, -459.6699999986626, 0.000_000_000_001);
    public static readonly (ulong K, ulong C, ulong F, ulong delta) HugeWhole = (10_000_000_000_000_000_273, 10_000_000_000_000_000_000, 18_000_000_000_000_000_032, delta: 1);
    public static readonly (ulong K, ulong C, ulong F, ulong delta) Longest = (10_248_191_152_060_862_737, 10_248_191_152_060_862_464, 18_446_744_073_709_551_615, delta: 1);
}

public static class Zero
{
    public static readonly (double K, double C, double F, double delta) Kelvin = (0, -273.15, -459.67, 0.000_000_001);
    public static readonly (double K, double C, double F, double delta) Celsius = (273.15, 0, 32, 0.000_000_001);
    public static readonly (double K, double C, double F, double delta) Fahrenheit = (255.37222222222, -17.7777777777, 0, 0.000_000_001);
}
