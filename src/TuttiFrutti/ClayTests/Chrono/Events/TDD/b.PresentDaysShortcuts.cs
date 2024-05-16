namespace ClayTests.Chrono.Events.TDD;
public class PresentDaysShortcuts
{
    [Test]
    public void Exact() {
        var era = Era.Common;

        var today = era.This.Day;
        var caToday = era.circa().Prev.Day;
        var tomorrow = era.Next.Day;
        var yesterday = era.Prev.Day;

        //var dayAfterTomorrow = era.At.TodayAdd(2);
        //var weekAgo = era.At.TodayAdd(-7);
    }

    [Test]
    public void Approximate() {
        var era = Era.Common;

        var ca = era.circa().Next.Day;
        var currentDecade = era.circa(5).This.Day;
        //var approximatelyFromTomorrow = era.circa(1).TodayAdd(2);

        //var aboutMonthAgo = era.circa(2).This.TodayAdd(-30);
        //var aboutYearLater = era.circa(10).TodayAdd(365);
    }

    [Test]
    public void Nova() {
        // ToDo:
        var footballEM = Era.Common.Year(2024);
        var CE = Era.Common;

        var BCE = Era.BeforeCommon;
    }
}
