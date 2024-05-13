namespace AbcChrono.Sol3.Calendar;
public interface IEra : IYearCentiMille,
    IApproximate<IYearCentiMille, ushort>,
    IDated<ICalendar_wCa<ICalendar>>;
