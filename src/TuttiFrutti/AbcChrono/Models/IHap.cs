namespace AbcChrono.Models;
public interface IHap : IBasal, IConfidence<uint>
{
    byte? DayNr { get; internal set; }
    Month MonthName { get; internal set; }
    ulong AbsYear { get; internal set; }
    new uint Delta { get; internal set; }
}

