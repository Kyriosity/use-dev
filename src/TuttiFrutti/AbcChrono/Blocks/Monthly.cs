using AbcChrono.Blocks.Bits;

namespace AbcChrono.Blocks;
public class Monthly : Basal
{
    public Monthly() : base("MONTHLY") { }

    protected Yearly Next(Month monthName, byte dayNr = 0) => new Yearly($" {monthName} {dayNr}");

    public Yearly January(byte dayNr) => Next(Month.January, dayNr); public Yearly January() => Next(Month.January);
    public Yearly February(byte dayNr) => Next(Month.February, dayNr); public Yearly February() => Next(Month.February);
    public Yearly March(byte dayNr) => Next(Month.March, dayNr); public Yearly March() => Next(Month.March);
    public Yearly April(byte dayNr) => Next(Month.April, dayNr); public Yearly April() => Next(Month.April);
    public Yearly May(byte dayNr) => Next(Month.May, dayNr); public Yearly May() => Next(Month.May);
    public Yearly June(byte dayNr) => Next(Month.June, dayNr); public Yearly June() => Next(Month.June);
    public Yearly July(byte dayNr) => Next(Month.July, dayNr); public Yearly July() => Next(Month.July);
    public Yearly August(byte dayNr) => Next(Month.August, dayNr); public Yearly August() => Next(Month.August);
    public Yearly September(byte dayNr) => Next(Month.September, dayNr); public Yearly September() => Next(Month.September);
    public Yearly October(byte dayNr) => Next(Month.October, dayNr); public Yearly October() => Next(Month.October);
    public Yearly November(byte dayNr) => Next(Month.November, dayNr); public Yearly November() => Next(Month.November);
    public Yearly December(byte dayNr) => Next(Month.December, dayNr); public Yearly December() => Next(Month.December);
}

public class Monthly_wShortcuts : Monthly
{
    public string Today(short addDays = 0) {
        var dt = DateTime.Today.AddDays(addDays);
        Model = $"Month: {(Month)dt.Month}";
        Model = $"Day: {(byte)dt.Day}";
        Model = $"";
        return Model;
    }
    public string Yesterday() => Today(-1);
    public string Tomorrow() => Today(1);
}

public class Monthly_wCa : Monthly
{
    public Monthly circa(byte delta = 1) { Model = $" - ca+/-{delta} -"; return this; }
}

public class Monthly_wShortcuts_wCa : Monthly_wShortcuts
{
    public Monthly_wShortcuts circa(byte delta = 1) { Model = $" - ca+/-{delta} -"; return this; }
}