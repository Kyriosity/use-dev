using AbcChrono.Mk.Blocks;
using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Providers;

class Full : YearsX1_000_000_000,
    IApproximate<YearsX1_000_000_000, ushort>,
    IDated,
    IPresentShortcuts
{
    public Full() : base("ERA") { }

    public YearsX1_000_000_000 circa() => circa(1);

    public YearsX1_000_000_000 circa(ushort delta = 1) {
        Model = $"( ca+/-{delta})";
        return this;
    }

    public Full Ago {
        get {
            Model = $"AGO";
            return this;
        }
    }

    public IMonths_wCa At { get; } = new Calendar_wCa("calendar");

    public ICalendarProps Prev => new CalendarProps();

    public ICalendarProps This => new CalendarProps();

    public ICalendarProps Next => new CalendarProps();
}
