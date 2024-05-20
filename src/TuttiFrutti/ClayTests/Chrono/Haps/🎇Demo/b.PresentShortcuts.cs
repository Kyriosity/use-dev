namespace ClayTests.Chrono.Haps.Demo;
public class PresentShortcuts
{
    [Test]
    public void Days() {
        var calendar = Era.Common;

        var today = calendar.This.Day;
        var tomorrow = calendar.Next.Day;
        var yesterday = calendar.Prev.Day;

        var dayAfterTomorrow = calendar.This.plus(2).Day;
        var weekAgo = calendar.This.minus(7).Day;

        var circaYearAfter = calendar.circa(10).This.plus(365).Day;
    }

    [Test]
    public void Months() {
        var currentMonth = Era.Common.This.Month;
        var thisMonthYearAgo = Era.Common.This.minus(12).Month;
        var caNextYear = Era.Common.This.plus(12).Month;
        var nextMonth = Era.Common.Next.Month;
        var prevMonth = Era.Common.Prev.Month;
    }

    [Test]
    public void Years() {
        var era = Era.Common;

        var const_fullSelfDrive = era.Next.Year;

        var nowadays = era.This.Year;
        var declarationSubmitted = era.Prev.Year;

        var centuryAgo = era.This.minus(12).Year;
        var farFutureEvent = era.This.plus(500).Year;
    }

    [Test]
    public void Approximate() {
        var era = Era.Common;

        var nextDecade = era.circa(3).This.plus(10).Year;


        var ca = era.circa().Next.Day;
        var currentDecade = era.circa(5).This.Day;
        var approximatelyFromTomorrow = era.circa(1).This.plus(2).Day;

        var aboutMonthAgo = era.circa(2).This.minus(30).Day;
        var aboutYearLater = era.circa(10).This.plus(365).Day;

        var sometimeNextCentury = era.circa(10).This.plus(100).Year;

        var onceUponATime = era.circa(100).This.minus(1500).Year;
    }
}
