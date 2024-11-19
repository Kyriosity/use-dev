namespace AbcChrono.Timescales.Models;
public interface IHap : IBasal, IConfidence<ushort>
{
    byte? DayNr { get; internal set; }
    Month MonthName { get; internal set; }
    ulong AbsYear { get; internal set; }
    new ushort Delta { get; internal set; }
}

