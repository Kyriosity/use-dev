using N_Val.Phys.Temperature;

namespace TD.N_Val;

public static class TestArgs
{
    public static class Temperatures
    {
        public static readonly (float K, float C, float F, float delta) WaterBoiling = (373.15F, 100.0F, 212.00F, 0.00005F);
        public static readonly (decimal K, decimal C, decimal F, decimal delta) WaterTriplePoint = (273.16M, C: 0.01M, F: 32.018M, delta: 0.001M);
        public static readonly (int K, int C, int F, int delta) SunSurface = (5772, 5499, 9930, 1);
        public static readonly (double K, double C, double F, double delta) AbsZero = (0.00, -273.15, -459.67, 0.00000000001);
        public static readonly (double K, double C, double F, double delta) QuicksilverMelting = (234.32, -38.83, -37.894, 0.000001);
        public static readonly (int K, int C, int F, int delta) GoldMelting = (1337, 1064, 1947, 1);

        public readonly static object[] MutitypeNumerics_KelvinCelciusFahrenheit = {
            new object[] { nameof(WaterBoiling), WaterBoiling },
            new object[] { nameof(WaterTriplePoint),  WaterTriplePoint },

            new object[] { "Minus math op value", (-1234.567, -1507.717, -2681.8906, delta: 0.00000001) },

            new object[] { "Potassium atoms < abs. 0", (-0.000000001, -273.150000001, -459.6700000018, 0.00000000001) }, // www.mpg.de/research/negative-absolute-temperature
   
            new object[] { "Recorded min on Earth", (K: 183.95, C: -89.2, F: -128.56, delta: 0.000000001) },

            new object[] { nameof(AbsZero), AbsZero },

            new object[] { nameof(QuicksilverMelting), QuicksilverMelting},
            new object[] { nameof(GoldMelting), GoldMelting },
            new object[] { nameof(SunSurface), SunSurface},
            new object[] { "Hottest in Universe", (K: _uniHottest, C: _uniHottest, F: _uniHottestF, delta: deltaForHugeNumbers) }
        };

        private const float _uniHottest = 142_000_000_000_000_000_000_000_000_000_000.00F;
        private const float _uniHottestF = 255_599_999_999_999_999_999_999_999_999_989.00F;

        private const float deltaForHugeNumbers = _uniHottest / 100;

        public static class Math
        {
            public readonly static object[] Sums = {
            (x1: (0, C), x2: (17, C), expected: (17, C), delta: 0),
            (x1: (0.31, C), x2: (17.2, C), expected: (17.33, C), delta: 0)
        };

            public readonly static object[] Diffs = {
                (0, K, 0, K, expected: (val: 0, unit: K, delta: 0)),
                (0.00D, C, double.Epsilon, C, expected: (val: 0.00D, unit: C, delta: 0.00D)),

                (1, K, 8, C, expected: (val: 17, unit: K, delta: 0)),
                (0.24, F, 17.2, K, expected: (val: 12.23, unit: F, delta: 0.22)),
            };

            private const In K = In.Kelvin;
            private const In C = In.Celsius;
            private const In F = In.Fahrenheit;
        }
    }
}
