namespace AbcChrono.Models;
class Hap : Universal, IHap
{
    public byte? DayNr { get; set; }
    public Month MonthName { get; set; } = Month.Undefined;

    public ushort Delta { get; set; } = 0;

    public ulong AbsYear { get => _absYear ?? NotSet.Throw(AbsYear); set => _absYear = value; }
    internal ulong? _absYear;
}

