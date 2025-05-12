namespace MeasData.Mass;
public partial class Synonyms
{
    protected const string gram = nameof(gram);
    protected const string gramme = gram;
    protected const string g = gram;

    protected const string microgram = nameof(microgram);

    protected const string milligram = nameof(milligram);

    protected const string kilogram = nameof(kilogram);
    protected const string kilograms = kilogram;
    protected static readonly string kg = kilogram;

    protected static readonly string pound = nameof(pound);
    protected static readonly string lb = pound;
    protected static readonly string lbs = pound;

    protected static readonly string ounce = nameof(ounce);
    protected static readonly string oz = ounce;

    protected static readonly string tonne = nameof(tonne);
    protected static readonly string tonnes = tonne;

    protected static readonly string US_ton = "US ton";

    protected const double thousand = 1_000;
    protected const double million = 1_000_000;
    // DO NOT USE protected const int billion = 1_000_000_000; // double meaning (short vs. long scale)

    protected static readonly ulong peta = 1_000_000_000_000_000; // Math.Pow(10, 15);
    protected static readonly double yotta = 10.Pow(24);
    protected static readonly double ronna = 10.Pow(27);
    protected static readonly double tenX15 = ronna;
}
