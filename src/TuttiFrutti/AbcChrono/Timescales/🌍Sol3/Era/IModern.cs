using AbcChrono.Timescales.Sol3.Calendar;
using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3.Era;
public interface IModern<Anni>
    : IYearCenti_wShortcuts,
    IApproximate<IYearCenti_wShortcuts, ushort>,
    IDated<Anni>

    where Anni : IAnnual;


public interface IYearCenti_wShortcuts
    : IYearCenti, IPresentShortcuts;