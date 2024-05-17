using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Blocks;
class CalendarProps(IEvent model) : Basal(model), ICalendarProps_wShift
{
    public IEvent Day => model; // ToProp: 

    public IEvent Month => model; // ToProp: 

    public IEvent Year => model; // ToProp: 

    public ICalendarProps minus(ushort shift) => this; // ToProp: 
    public ICalendarProps plus(ushort shift) => this; // ToProp: 
}

