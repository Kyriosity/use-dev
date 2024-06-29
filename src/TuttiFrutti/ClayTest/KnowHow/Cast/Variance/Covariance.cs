namespace ClayTest.KnowHow.Cast.Variance;
using Abc.Marks;

public class Covariance
{
    [Test]
    public void BuildOut() {
    }
}

class Originator<Res> : IOriginator<Res> where Res : IDenom<string>
{
    public Res Name() => NotImplemented.Unneccessary("");
}


interface IOriginator<out Res> where Res : IDenom<string>
{
    Res Name();
}