namespace AbcChrono.Timescales;
public class Hist
{
    public static IHumanEra_wAgo Human => new HumanHistory(On.ModernHumans); // modern humans, since 300'000 years ago
    public static IGeoAges_wAgo Geo => new GeoAges(On.EarthHistory);
    public static IAeon_wAgo Eon => new Aeon(On.Universe); // universe, current age 13'787±0.020 billion years
}