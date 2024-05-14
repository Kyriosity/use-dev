namespace ClayTests.Chrono.Events.TDD;
public class PresentDaysShortcuts
{
    [Test]
    public void Exact() {
        var calendar = Era.Common.At;

        //var aaa = calendar.Prev;
        //var aaad = calendar.Next;


        //calendar.circa().April().This.Year;

        var today = calendar.Today;
        var yesterday = calendar.Yesterday;
        var tomorrow = calendar.Tomorrow;

        var dayAfterTomorrow = calendar.TodayAdd(2);
        var weekAgo = calendar.TodayAdd(-7);
    }

    [Test]
    public void Approximate() {
        var calendar = Era.Common.At;

        var currentDecade = calendar.circa(5).Today;
        var approximatelyFromTomorrow = calendar.circa(1).TodayAdd(2);

        var aboutMonthAgo = calendar.circa(2).TodayAdd(-30);
        var aboutYearLater = calendar.circa(10).TodayAdd(365);
    }

    [Test]
    public void Nova() {
        var footballEM = Era.Common.Year(2024);
        var CE = Era.Common;

        var BCE = Era.BeforeCommon;
    }
}
