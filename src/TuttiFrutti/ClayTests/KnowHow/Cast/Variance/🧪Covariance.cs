namespace ClayTestToDelete.KnowHow.Cast.Variance;
public class Variance
{
    [Test]
    public void CantMatch() {

    }
}

interface Publisher<out W, P>
{
    public T Make<T>();
    //public T Make<out T>(); CANT COMPILE
    public P Build<T>();
}
