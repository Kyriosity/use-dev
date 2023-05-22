using Abc.Mk.Coll.Gtor;
namespace Test_Learn.Abc.Coll;
internal static class Providers
{
    public static IEnumerable<TestCaseData> AllTypesItemsAccuBuilders {
        get {
            yield return new TestCaseData(new PlainItemsAccuBuilder());
            yield return new TestCaseData(new PlainItemsAccuBuilder().OnSet<object>(x => x));
        }
    }
}
