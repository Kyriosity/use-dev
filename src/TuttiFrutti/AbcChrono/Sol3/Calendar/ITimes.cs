using AbcChrono.Sol3.Monthly;

namespace AbcChrono.Sol3.Calendar;
public interface ITimes : IYearCenti,
    IApproximate<IYearCenti, ushort>,
    IDated<ICalendar_wShortcuts_wCa>;
