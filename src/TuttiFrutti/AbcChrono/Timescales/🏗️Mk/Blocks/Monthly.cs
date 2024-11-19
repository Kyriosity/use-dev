using AbcChrono.Timescales.Sol3.Calendar;
using AbcChrono.Timescales.Sol3.Yearly;
using AbcChrono.Units;

namespace AbcChrono.Timescales.Sol3.Mk.Blocks;
class Monthly<Anni>(IHap model) : Basal(model), IMonths<Anni>
    where Anni : IAnnual
{
    public Anni January(byte dayNr) => (Anni)toYear(Month.January, dayNr); public Anni January() => (Anni)toYear(Month.January);
    public Anni February(byte dayNr) => (Anni)toYear(Month.February, dayNr); public Anni February() => (Anni)toYear(Month.February);
    public Anni March(byte dayNr) => (Anni)toYear(Month.March, dayNr); public Anni March() => (Anni)toYear(Month.March);
    public Anni April(byte dayNr) => (Anni)toYear(Month.April, dayNr); public Anni April() => (Anni)toYear(Month.April);
    public Anni May(byte dayNr) => (Anni)toYear(Month.May, dayNr); public Anni May() => (Anni)toYear(Month.May);
    public Anni June(byte dayNr) => (Anni)toYear(Month.June, dayNr); public Anni June() => (Anni)toYear(Month.June);
    public Anni July(byte dayNr) => (Anni)toYear(Month.July, dayNr); public Anni July() => (Anni)toYear(Month.July);
    public Anni August(byte dayNr) => (Anni)toYear(Month.August, dayNr); public Anni August() => (Anni)toYear(Month.August);
    public Anni September(byte dayNr) => (Anni)toYear(Month.September, dayNr); public Anni September() => (Anni)toYear(Month.September);
    public Anni October(byte dayNr) => (Anni)toYear(Month.October, dayNr); public Anni October() => (Anni)toYear(Month.October);
    public Anni November(byte dayNr) => (Anni)toYear(Month.November, dayNr); public Anni November() => (Anni)toYear(Month.November);
    public Anni December(byte dayNr) => (Anni)toYear(Month.December, dayNr); public Anni December() => (Anni)toYear(Month.December);

    protected IYearX1WithCurrent toYear(Month month) => new Annual(Model.Month(month));

    protected IYearX1WithCurrent toYear(Month month, byte dayNr) {
        ArgumentOutOfRangeException.ThrowIfZero(dayNr);
        var maxDaysInMonth = month == Month.February ? 29 :
           month is Month.April or Month.June or Month.September or Month.November ? 30 : 31;
        ArgumentOutOfRangeException.ThrowIfGreaterThan(dayNr, maxDaysInMonth);

        return new Annual(Model.Day(dayNr).Month(month));
    }
}

class Monthly_wCa<Anni>(IHap model) : Monthly<Anni>(model), IMonths_wCa<Anni>
    where Anni : IAnnual
{
    public IMonths<Anni> circa(short delta) {
        Model.circa(delta);
        return this;
    }

    public IMonths<Anni> circa() => circa(1);
}
