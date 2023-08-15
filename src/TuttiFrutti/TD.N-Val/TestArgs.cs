using N_Val.Phys.Temperature;

namespace TD.N_Val;

public static class TestArgs
{
    public static class Temperatures
    {
        public readonly static object[] MutitypeNumerics_KelvinCelciusFahrenheit = {
            new object[] { "Minus math op value", (K: -1234.567, C: -1507.717, F: -2681.8906, delta: 0.00000001) },

            new object[] { "Potassium atoms < abs. 0", (K: -0.000000001, C: -273.150000001, F: -459.6700000018, delta: 0.00000000001) }, // www.mpg.de/research/negative-absolute-temperature
            new object[] { "Absolute zero", (K: 0.00, C: -273.15, F: -459.67, delta: 0.00000000001) },
            new object[] { "Recorded min on Earth", (K: 183.95, C: -89.2, F: -128.56, delta: 0.000000001) },

            new object[] { "Water boiling", (K: (float)373.15, C: (float)100.0, F: (float)212.00, delta: (float)0.00005) },
            new object[] { "Water triple point", (K: (decimal)273.16, C: (decimal)0.01, F: (decimal)32.018, delta: (decimal)0.001) },

            new object[] { "Quicksilver melting", (K: 234.3, C: -38.83, F: -38.001999999999, delta: 0.02) },
            new object[] { "Gold melting", (K: 1337, C: 1064, F: 1947, delta: 1) },
            new object[] { "Sun surface", (K: 5772, C: 5499, F: 9930, delta: 1) },
            new object[] { "Hottest in Universe", (K: _uniHottest, C: _uniHottest, F: _uniHottestF, delta: deltaForHugeNumbers) }
        };

        private const float _uniHottest = (float)142_000_000_000_000_000_000_000_000_000_000.00;
        private const float _uniHottestF = (float)255_599_999_999_999_999_999_999_999_999_989.00;

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

            private const Unit K = Unit.Kelvin;
            private const Unit C = Unit.Celsius;
            private const Unit F = Unit.Fahrenheit;
        }
    }
}
