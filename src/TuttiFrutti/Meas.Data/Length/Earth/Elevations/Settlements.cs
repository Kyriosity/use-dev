namespace Meas.Data.Length.Earth;
public partial class Elevations
{
    public static readonly Dir Settlements = new() {
        ["La Rinconada"] = [(5_100, meter), (16_732.28, foot), (5_577.43, yard)], // Peru
        ["Tuiwa, Tibet"] = [(5_070, m), (16_633.86, feet), (5_544.62, yard)],
        ["Lobuche, Nepal"] = [(4_940, m), (16_207.35, foot), (5_402.45, yard)],
        ["Santa Barbara, Bolivia"] = [(4_770, m), (15_649.61, feet)],
        ["Karzok, Ladakh"] = [(4_570, m), (14_993.44, ft)]
    };
}
