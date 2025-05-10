namespace AbcChrono.Timescales.Models;
readonly struct MonthYear(int year, byte month)
{
    public static MonthYear From(DateTime dt) => new MonthYear(dt.Year, (byte)dt.Month);

    public MonthYear AddMonths(int shift) {
        return new MonthYear(Year + (shift / 12), (byte)(Month + (shift % 12)));
    }

    public readonly int Year = year;
    public readonly byte Month = month;
}
