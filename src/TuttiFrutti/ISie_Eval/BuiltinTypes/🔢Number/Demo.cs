using Abc.Logic.Fuse;
using AbcRefl.Implementation;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo : Setup.Arrange
{
    [Test]
    public void InWords() {
        //var res = 1.In<Latin>().FRACTION_STYLE - words or ?; // .Words;
        // in Roman WithNumbers
        // ? minus wording

        Func<bool, bool, bool> testMe = Unpack<bool, IDisjunct>();

        var res = testMe(true, true);
        var res2 = testMe(false, true);
        var res3 = testMe(false, false);

        testMe = Unpack<bool, IConjunct>();
        var conj = testMe(true, true);
        var conj2 = testMe(true, false);
    }


    protected static Func<T, T, T> Unpack<T, I>() {
        return (a, b) => (T)Method.Default<I>("Join").Invoke(a, b);
    }

    // IsNatural
    // IsPerfect

}
