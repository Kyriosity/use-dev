namespace AbcChrono.Sol3.Mk.Blocks;
class Monthly(IEvent model) : Basal(model), IMonths
{
    protected IAnnual toYear(Month monthName, byte dayNr = 0) => new Annual(Model); // // ToProp: $" {monthName} {dayNr}");

    public IAnnual January(byte dayNr) => toYear(Month.January, dayNr); public IAnnual January() => toYear(Month.January);
    public IAnnual February(byte dayNr) => toYear(Month.February, dayNr); public IAnnual February() => toYear(Month.February);
    public IAnnual March(byte dayNr) => toYear(Month.March, dayNr); public IAnnual March() => toYear(Month.March);
    public IAnnual April(byte dayNr) => toYear(Month.April, dayNr); public IAnnual April() => toYear(Month.April);
    public IAnnual May(byte dayNr) => toYear(Month.May, dayNr); public IAnnual May() => toYear(Month.May);
    public IAnnual June(byte dayNr) => toYear(Month.June, dayNr); public IAnnual June() => toYear(Month.June);
    public IAnnual July(byte dayNr) => toYear(Month.July, dayNr); public IAnnual July() => toYear(Month.July);
    public IAnnual August(byte dayNr) => toYear(Month.August, dayNr); public IAnnual August() => toYear(Month.August);
    public IAnnual September(byte dayNr) => toYear(Month.September, dayNr); public IAnnual September() => toYear(Month.September);
    public IAnnual October(byte dayNr) => toYear(Month.October, dayNr); public IAnnual October() => toYear(Month.October);
    public IAnnual November(byte dayNr) => toYear(Month.November, dayNr); public IAnnual November() => toYear(Month.November);
    public IAnnual December(byte dayNr) => toYear(Month.December, dayNr); public IAnnual December() => toYear(Month.December);
}


class Monthly_wCa(IEvent model) : Monthly(model), IMonths_wCa
{
    public IMonths circa(short delta = 1) {
        // ToProp: Model = $" - ca+/-{delta} -";
        return this;
    }
}
