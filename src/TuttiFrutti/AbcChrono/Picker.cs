using AbcChrono.Blocks;

namespace AbcChrono;

// Era.Common = 

public class Picker<TMonthly> : YearCentMilleMegaGiga
    where TMonthly : Monthly, new()
{
    public Picker() : base("ERA") { }

    public YearCentMilleMega circa(short delta = 1) {
        Model = $"( ca+/-{delta})";
        return this;
    }

    public TMonthly At => new();
}

public class Picker_wAgo<TCalendar> : Picker<TCalendar>
    where TCalendar : Monthly, new()
{
    public Picker<TCalendar> Ago {
        get {
            Model = $"AGO";
            return this;
        }
    }

}