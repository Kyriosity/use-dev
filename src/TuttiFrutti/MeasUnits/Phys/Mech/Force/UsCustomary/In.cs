namespace MeasUnits.Phys.Mech.Force.UsCustomary;

[Factored]
public enum In
{
    [Abbr("lbf")]
    pound_force = 16 * ounce_force,

    [Abbr("kip")]
    kilopound = 16_000, // 1000 pounds-force, for structure engineering

    shortton_force = 2_000 * pound_force,
    longton_force = 2_240 * pound_force,

    [Abbr("ozf")]
    ounce_force = 1 // same ratio as pound to ounce 1/16
}
