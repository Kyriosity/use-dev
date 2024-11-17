namespace AbcExt.Chrono.Units.Annual;

[Factored]
public enum In : uint
{
    Undefined = 0,

    [Alias("aestas", "annual")]
    Year = 1,

    Decade = 10,
    Century = 100,
    Quincentenary = 500,

    Millennium = 1_000,
    Bimillennium = 2_000,
    Trimillennium = 3_000,
    Quadrimillennium = 4_000,
    Quinmillennium = 5_000,
    Sexmillennium = 6_000,
    Septmillennium = 7_000,
    Octomillennium = 8_000,
    Novamillennium = 9_000,
    Decamillennium = 10_000,

    [Alias("Myriad")]
    Centamillennial = 100_000,

    [Alias("Epoch")]
    Megaannum = 1_000_000,
    Billion = 1_000_000_000,
}
