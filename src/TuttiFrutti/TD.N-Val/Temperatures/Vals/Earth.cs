namespace TestData.N_Val.Temperatures.Vals;
public static class Earth
{
    public static readonly (int K, int C, int F, int delta) AvgSurface = (287, 14, 57, 1);

    public static readonly (double K, double C, double F, double delta) RecordedMin = (183.95, -89.2, -128.56, 0.000000001);

    // wmo.asu.edu/content/world-highest-temperature
    public static readonly (double K, double C, double F, double delta) RecordedMax = (329.85, 56.7, 134.06, 0.000000001);

    public static readonly (double K, double C, double F, double delta) AvgOceanSurface_31Jul2023 = (294.1148, 20.9648, 69.73664, 0.000001);

    public static readonly (ushort K, ushort C, ushort F, ushort delta) EtnaMagma = (1353, 1080, 1976, 1);
}
