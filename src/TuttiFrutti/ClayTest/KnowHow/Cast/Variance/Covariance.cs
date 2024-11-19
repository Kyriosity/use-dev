using Abc.Marks;
namespace ClayTest.KnowHow.Cast.Variance;

public class Covariance
{
    [Test]
    public void BuildOut() {
    }
}

class Originator<Res> : IOriginator<Res> where Res : IDenom<string>
{
    public Res Name() => NotImplemented.Unneccessary("Stubbing");
}


interface IOriginator<out Res> where Res : IDenom<string>
{
    Res Name();
}
