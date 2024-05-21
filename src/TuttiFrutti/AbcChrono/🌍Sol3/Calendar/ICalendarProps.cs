namespace AbcChrono.Sol3.Calendar;
public interface ICalendarProps
{
    IHap Day { get; }
    IHap Month { get; }
    IHap Year { get; }
}


public interface ICalendarProps_wShift : ICalendarProps
{
    ICalendarProps plus(ushort val);
    ICalendarProps minus(ushort val);
}

