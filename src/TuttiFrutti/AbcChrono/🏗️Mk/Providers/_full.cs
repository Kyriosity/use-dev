using AbcChrono.Mk.Blocks;
using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Providers;

class Full(Scale scale) : YearsX1_000_000_000(new Event { Epoch = scale }),
    IApproximate<YearsX1_000_000_000, ushort>,
    IDated, IPresentShortcuts
{
    public YearsX1_000_000_000 circa() => circa(1);

    public YearsX1_000_000_000 circa(ushort delta = 1) {
        // ToProp:  = $"( ca+/-{delta})";
        return this;
    }

    public Full Ago {
        get {
            // ToProp: Model = $"AGO";
            return this;
        }
    }

    public IMonths_wCa At => new Monthly_wCa(Model);

    public ICalendarProps_wShift Prev => new CalendarProps(Model);

    public ICalendarProps_wShift This => new CalendarProps(Model);

    public ICalendarProps_wShift Next => new CalendarProps(Model);
}
