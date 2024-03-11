namespace MeasUnits.Phys.Distance.Length.Ancient.Egyptian;

// ToDo: [Factored]
public enum In
{
    Undefined = 0,

    [Alias("Digit", "fingerbreadth", "Tebā")]
    finger,

    [Alias("Shesep")]
    palm,

    [Alias("Handsbreadth")]
    hand,
    fist,

    doubleHandbreadth,

    [Alias("Pedj-Sheser", "Shat Nedjes", "little Shat")]
    smallSpan,

    [Alias("Half-Cubit", "Pedj-Aa", "Shat Aa", "great Shat")]
    greatSpan,

    [Alias("Djeser", "Ser", "Bent arm")]
    Foot,

    [Alias("Remen", "upper Arm")]
    Shoulder,

    [Alias("short Cubit", "Meh Nedjes")]
    smallCubit,

    [Alias("Royal Cubit", "Sacred Cubit", "Meh Nesut", "Meh Nisut", "Mahi", "Eli")]
    cubit = 1,

    [Alias("Nebiu")]
    pole,

    [Alias("Rod of Cord", "Schoinion", "Khet", "Stick of Rope")]
    rod,

    [Alias("River Measure", "League", "Ater", "Iter", "Iteru")]
    Schoenus, // ~10.5km
}
