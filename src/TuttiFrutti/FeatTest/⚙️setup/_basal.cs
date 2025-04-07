namespace FeatTest.setup;
public abstract class Basal : AbcExtNUnit.Asserted.Full
{
    internal TestClass Dummy = new();

    protected static int DivideBy(int divisor) => 5 / divisor;

    protected void Increment(byte arg) {
        unchecked {
            arg++;
            arg--;
        }
        // next will throw Overflow exception provided Project Properties/Build/Advanced/✅Check for arithmetic overflow 
        arg++;
    }

    protected void ValidAction(int arg) { var description = $"{arg} supplied"; }

    protected void InvalidAction(int arg) => throw new InvalidOperationException("for test purposes only");

    protected static bool TruthValueFunction(int seed) => true;
    protected static bool TruthValueFunction(string seed) => "" != seed;

    protected static bool? ReturnNothing(bool yes) => yes ? null : yes;
}
