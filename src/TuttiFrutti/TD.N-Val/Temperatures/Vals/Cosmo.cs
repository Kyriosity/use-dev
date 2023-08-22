namespace TestData.N_Val.Temperatures.Vals;
public static class Cosmo
{
    public static readonly (double K, double C, double F, double delta) Space = (2.725, -270.425, -454.765, 0.000_001);

    public static readonly (ushort K, ushort C, ushort F, ushort delta) EarthCore = (5_473, 5_200, 9_392, 1);

    public static readonly (uint K, uint C, uint F, uint delta) SunCore = (15_000_000, 15_000_000, 27_000_000, 1_000);
    public static readonly (int K, int C, int F, int delta) SunSurface = (5_772, 5_499, 9_930, 1);

    public static readonly (float K, float C, float F, float delta) UniverseHottest = (K: _uniHottest, C: _uniHottest, _uniHottestFahrenheit, delta: deltaForHugeNumbers);
    private const float _uniHottest = 142_000_000_000_000_000_000_000_000_000_000.00F;
    private const float _uniHottestFahrenheit = 255_599_999_999_999_999_999_999_999_999_989.00F;
    private const float deltaForHugeNumbers = _uniHottest / 100;
}
