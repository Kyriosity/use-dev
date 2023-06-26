using Abc.Mk.Coll.Gtor;

namespace Abc.Test_Learn.Coll;
internal static class Providers
{
    public static IEnumerable<TestCaseData> AllTypesItemsAccuBuilders {
        get {
            yield return new TestCaseData(new Accu());
            yield return new TestCaseData(new Accu().OnSet<object>(x => x));
        }
    }
}
