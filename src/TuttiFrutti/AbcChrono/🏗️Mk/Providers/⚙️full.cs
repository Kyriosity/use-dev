using AbcChrono.Mk.Blocks;
using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Providers;

class Full(On scale) : YearsX1_000_000_000(new Hap { Epoch = scale }),
    IApproximate<YearsX1_000_000_000, ushort>,
    IDated, IPresentShortcuts
{
    public YearsX1_000_000_000 circa() => circa(1);

    public YearsX1_000_000_000 circa(ushort delta = 1) {
        Model.circa(delta);
        return this;
    }

    public Full Ago {
        get {
            Model.Ago();
            return this;
        }
    }

    public IMonths_wCa At => new Monthly_wCa(Model);

    public ICalendarProps_wShift Prev => new CalendarProps(Model, -1);

    public ICalendarProps_wShift This => new CalendarProps(Model);

    public ICalendarProps_wShift Next => new CalendarProps(Model, 1);
}
