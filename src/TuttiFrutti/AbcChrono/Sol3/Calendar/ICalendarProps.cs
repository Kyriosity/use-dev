namespace AbcChrono.Sol3.Calendar;
public interface ICalendarProps
{
    string Day { get; }
    string Month { get; }
    string Year { get; }
}


public interface ICalendarProps_wShift : ICalendarProps
{
    ICalendarProps plus(ushort shift);
    ICalendarProps minus(ushort shift);
}

