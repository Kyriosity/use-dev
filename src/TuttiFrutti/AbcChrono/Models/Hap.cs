namespace AbcChrono.Models;
class Hap : Universal, IHap
{
    public byte? DayNr { get; set; }
    public Month MonthName { get; set; } = Month.Undefined;

    public uint Delta { get; set; } = 0;
    public long UnixYear => _unixYear ?? NotSet.Throw(UnixYear);
    internal long? _unixYear;
}
