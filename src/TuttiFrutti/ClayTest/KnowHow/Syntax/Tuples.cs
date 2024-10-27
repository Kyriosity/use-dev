namespace ClayTest.KnowHow.Syntax;
public class Tuples
{
    [Test]
    public void TabularSwitch() {
        var aaa = new UsingDelegate<FilterDelegate> { };

    }

    private static string Recommend<T>(T[] cultures, ushort year, string format, bool nonFictionOnly = false)
        => (cultures, year, nonFictionOnly) switch {
            ([], > 2021, true) => format,
            ([var single], > 2020, _) => format,
            ([.. var single], > 2020, _) => format,
            (_, _, _) => format
        };
}


public class UsingDelegate<F> where F : Delegate
{
    public void TestDelGen() {
        var a = new F();

    }
}


public delegate bool FilterDelegate(int p);

public class Multicaster<T> where T : MulticastDelegate { }
