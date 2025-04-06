using AbcExtNUnit.Attributes.Directive;

namespace FeatTest.AssertByAssign.Predefined;
public class Intro : Basal
{
    [SyntaxDemo]
    public void Idea() {
        // descriptive, meaningful but long
        Assert.That(TruthValueFunction("important argument"), Is.True);

        // dubious but shorter with emphasized subjects 
        True = TruthValueFunction("important argument");
    }

    [Test]
    public void Predefined_Demo() {
        Null = ReturnNothing(true);
        Null = ReturnNothing(false); // will fail

        NotNull = "definitely not null";
        NotNull = NullStr; // will fail

        var arg = 2;
        True = TruthValueFunction(arg);
        False = TruthValueFunction(arg); // will fail
        NotNull = TruthValueFunction(arg);

        False = 2 * 2 == 5;

        Zero = 125 * 0;
        NonZero = 125 / 5;
        Zero = 0.999_999_999_999_999_999; // will fail

        One = 5 / 5;
        One = 1.00000000000000000000000001; // will fail
    }

    public void Exceptions() {
    }

    private static bool TruthValueFunction(int seed) => true;
    private static bool TruthValueFunction(string seed) => "" != seed;

    private static bool? ReturnNothing(bool yes) => yes ? null : yes;
}
