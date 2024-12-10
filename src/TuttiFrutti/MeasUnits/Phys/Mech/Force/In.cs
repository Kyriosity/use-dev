namespace MeasUnits.Phys.Mech.Force;

[Factored]
public enum In : ulong
{
    [Abbr("dyn")]
    dyne = 100_000 * newton,

    [Abbr("N")]
    newton = 1_000_000_000_000,

    [Abbr("lbf")]
    pound_force = 4_448_222_000_000,

    [Abbr("kip")]
    kilopound = 1_000 * pound_force,

    [Abbr("pdl")]
    poundal = 138_254_954_376, // since 1877, Absolute English system (1 pdl === 0.138'254'954'376 N)

    // DEPRECIATED!
    [Alias("kilopond")]
    kilogram_force = 9_806_650_000_000// === 9.806650 N
}
