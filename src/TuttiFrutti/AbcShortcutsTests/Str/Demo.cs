using AbcString_ext.Item;

namespace AbcShortcutsTests.Str;
public class Demo
{
    string multilineWhitespaces = @"   
    
   ";

    [Test]
    public void SyntaxOnly() {


        var isIt = string.IsNullOrWhiteSpace("     ");

        var strWithTabs = "   \t  ";
        Console.WriteLine($"Sstring of thetest: {strWithTabs}");
        isIt = string.IsNullOrWhiteSpace(multilineWhitespaces);
        isIt = string.IsNullOrWhiteSpace(strWithTabs);

        var len = multilineWhitespaces.Length;
        len = multilineWhitespaces.Trim().Length;

        const string smth = "NOT NU LL TEST STRING";
        _ = smth.Not().NullOrGrayspace;
        // SHORTCUTs
        ////////_ = smth.Is().NullOrWhitespace;
        ////////_ = smth.Is().NullOrWhitespace;

        // EXTRAs
        //_ = smth.Is().Ascii;
        //_ = smth.Is().Latin;

    }

    [Test]
    public void Extensions() {
        var sample = "               ";
        Assert.That(sample.Is().NullOrEmpty && sample.Is().NullOrWhitespace, Is.True);
        var obj = new object();
    }
}


public class Wrapper<T>(T? core)
{
    private readonly T? _core = core;
}

public interface WORK_TITLE<Fs> where Fs : IPredicates
{
    Fs With();
}


public interface ITraits<Fs> : IAffirmTraits<Fs>, INegateTraits<Fs> where Fs : IPredicates;

public interface IAffirmTraits<Fs> where Fs : IPredicates
{
    Fs Is();
}

public interface INegateTraits<Fs> where Fs : IPredicates
{
    Fs Not();
}


public interface IPredicates;