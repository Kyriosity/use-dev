namespace ClayTests.Chrono.Haps.Guards;
public class InvalidSyntax
{
    [Test]
    public void ShortcutsOnContext() {
        var canCompile = Era.Common.At.April().ThisYear();
        //var noneCompile = Era.BeforeCommon.At.April().ThisYear();
    }

    [Test]
    public void Calls() {
        /// next statements must NOT compile
        /* Era.Common.Millennium(1);
        Era.BeforeCommon.Decamillenniuum(1);
        Hist.Human.Year(1);
        Hist.Eon.Century(1); */
    }

    [Test]
    public void NegativeValues() {
        /// next statements must NOT compile
       /* Era.Common.Year(-1);
        Era.Common.At.August(-1);

        Hist.Eon.Megaannum(-1);
        Hist.Eon.Ago.Megaannum(-1); */
    }
}
