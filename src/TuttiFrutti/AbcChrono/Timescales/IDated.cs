using AbcChrono.Timescales.Sol3.Calendar;
using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales;
public interface IDated<Anni>
    where Anni : IAnnual
{
    IMonths_wCa<Anni> At { get; }
}
