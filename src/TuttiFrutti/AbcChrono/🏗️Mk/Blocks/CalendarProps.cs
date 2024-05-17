using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Blocks;
class CalendarProps(string model) : Basal(model), ICalendarProps_wShift
{
    public string Day => "day";

    public string Month => "month";

    public string Year => "year";

    public ICalendarProps minus(ushort shift) => this; // ToDo: adjust model
    public ICalendarProps plus(ushort shift) => this;
}

