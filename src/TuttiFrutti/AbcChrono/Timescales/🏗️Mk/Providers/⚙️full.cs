using AbcChrono.Timescales.Mk.Blocks;
using AbcChrono.Timescales.Sol3.Calendar;
using AbcChrono.Timescales.Sol3.Mk.Blocks;
using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Mk.Providers;

class Full<Anni>(On scale) : YearsX1_000_000_000(new Hap { Epoch = scale }),
    IApproximate<YearsX1_000_000_000, ushort>,
    IDated<Anni>, IPresentShortcuts

    where Anni : IAnnual
{
    public YearsX1_000_000_000 circa() => circa(1);

    public YearsX1_000_000_000 circa(ushort delta = 1) {
        Model.circa(delta);
        return this;
    }

    public Full<Anni> Ago {
        get {
            Model.Ago();
            return this;
        }
    }

    public IMonths_wCa<Anni> At => new Monthly_wCa<Anni>(Model);

    public ICalendarProps_wShift Prev => new CalendarProps(Model, -1);

    public ICalendarProps_wShift This => new CalendarProps(Model);

    public ICalendarProps_wShift Next => new CalendarProps(Model, 1);
}
