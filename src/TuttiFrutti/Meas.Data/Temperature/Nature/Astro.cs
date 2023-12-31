using Meas.Data.Setup.Extensions;

namespace Meas.Data.Temperature;
public partial class Nature : Setup.Synonyms, IDataSource
{
    public static readonly Dir Astro = new() {
        ["Space"] = [(2.725, Kelvin), (-270.425, Celsius), (-454.765, Fahrenheit)],

        ["Sun core"] = [(15_000_000, K), (27_000_000, F)],
        ["Sun surface"] = [(5_772, K), (9_930, F)],

        ["Lunar equator, day"] = [(400, K), (126.85, C), (260.33, F)],
        ["Moon surface, night"] = [(140, K), (-133.15, C), (-207.67, F)],

        ["Venus atmosphere, surface"] = [(740, K), (1_013.15, C), (872.33, F)],


        ["Sirius A, surface"] = [(9_940, K), (17_432.33, F)],

        ["Universe hottest"] = [(_uniHottest, K), (255_600_000_000_000_000_000_000_000_000_000.00, Fahrenheit)],
    };

    private const double _uniHottest = 142_000_000_000_000_000_000_000_000_000_000.00;
}
