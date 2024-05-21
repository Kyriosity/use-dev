using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Blocks;
class CalendarProps(IHap model, int shift = 0) : Basal(model), ICalendarProps_wShift
{
    public IHap Day => Model.Set(DateTime.Now.AddDays(shift));

    public IHap Month => Model.Set(MonthYear.From(DateTime.Now).AddMonths(shift));

    public IHap Year => Model.Set(DateTime.Now.Year + shift, In.Year);

    public ICalendarProps minus(ushort val) {
        shift -= val;
        return this;
    }
    public ICalendarProps plus(ushort val) {
        shift += val;
        return this;
    }
}
