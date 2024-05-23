namespace AbcChrono.Models;
public interface IHap : IBasal, IConfidence<uint>
{
    byte? DayNr { get; internal set; }
    Month MonthName { get; internal set; }
    long UnixYear { get; } // counts ± to the leap of 31/12/1969<->01/01/1970
    new uint Delta { get; internal set; }
}

