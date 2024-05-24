namespace AbcChrono;
public class Hist
{
    public static IHumanEra_wAgo Human => new HumanHistory(At.ModernHumans); // modern humans, since 300'000 years ago
    public static IGeoAges_wAgo Geo => new GeoAges(At.EarthHistory);
    public static IAeon_wAgo Eon => new Aeon(At.Universe); // universe, current age 13'787±0.020 billion years
}