namespace AbcChrono.Sol3.Calendar;
public interface ICalendarProps
{
    IEvent Day { get; }
    IEvent Month { get; }
    IEvent Year { get; }
}


public interface ICalendarProps_wShift : ICalendarProps
{
    ICalendarProps plus(ushort shift);
    ICalendarProps minus(ushort shift);
}

