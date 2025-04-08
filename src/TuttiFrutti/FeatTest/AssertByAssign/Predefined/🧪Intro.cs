namespace FeatTest.AssertByAssign.Predefined;
public class Intro : Basal
{
#if DEBUG
    [Test]
#endif
    public void Predefined_Demo() {
        Null = ReturnNothing(true);
        Null = ReturnNothing(false); // 👈 will fail

        NotNull = "definitely not null";
        NotNull = NullStr; // 👈 will fail

        var arg = 2;
        True = TruthValueFunction(arg);
        False = TruthValueFunction(arg); // 👈 will fail
        NotNull = TruthValueFunction(arg);

        False = 2 * 2 == 5;

        Zero = 125 * 0;
        NonZero = 125 / 5;
        Zero = 0.999_999_999_999_999_999; // 👈 will fail

        One = 5 / 5;
        One = 1.00000000000000000000000001; // 👈 will fail

        Empty = IdentityMap(string.Empty);
        Empty = IdentityMap("value written"); // 👈 will fail
        NotEmpty = IdentityMap("written");
    }

#if DEBUG
    [Test]
#endif
    public void Collections() {
        var nums = new int[] { };
        Empty = nums;
        nums = [1];
        NotEmpty = nums;

        var words = new List<string> { "una", "duo", "tres", "quattuor", "quīnque" };
        NotEmpty = words;
        words.Clear();
        Empty = words;
    }
}
