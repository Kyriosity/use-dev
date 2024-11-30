using AbcCommu.Errors.Sys;

namespace AbcShortcutsTests.Str;

public class Demo
{
    [Test]
    public void SyntaxOnly() {
        var smth = "NOT NULLL TEST STRING";

        // SHORTCATS
        _ = smth.Is().NullOrWhitespace;
        _ = smth.Not().NullOrWhitespace;

        // NEW
        _ = smth.Is().Ascii;
        _ = smth.Is().Latin;
    }



    [Test]
    public void Extensions() {
        var sample = "               ";
        Assert.That(sample.Not().NullOrEmpty && sample.Is().NullOrWhitespace, Is.True);


    }
}

public static class StrExtensions_Traits
{
    public static ITraits Is(this string subj) => NotImplemented.ToDo("Is stub");
    public static ITraits Not(this string subj) => NotImplemented.ToDo("Is stub");
}


public interface ITraits
{
    bool NullOrEmpty { get; }
    bool NullOrWhitespace { get; }
    bool NullOrGrayspace { get; }

    bool Ascii { get; }

    bool Latin { get; }
    bool LatinOrNumeric { get; }
}
