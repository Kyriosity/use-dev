using Abc.Mk.Coll.Gtor;
namespace Test_Learn.Abc.Coll;
internal static class Providers
{
    public static IEnumerable<TestCaseData> ItemsAccuBuilders {
        get {
            yield return new TestCaseData(new ItemsAccuBuilder());
            yield return new TestCaseData(new ItemsAccuBuilder());
        }
    }
}


