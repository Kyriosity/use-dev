namespace AbcChrono.Models;
class Hap : Universal, IHap
{
    public byte? DayNr { get; set; }
    public Month MonthName { get; set; } = Month.Undefined;

    public ushort Delta { get; set; } = 0;

    public ulong AbsYear { get => _absYear ?? NotSet.Throw(); set => _absYear = value; }
    private ulong? _absYear;
}

