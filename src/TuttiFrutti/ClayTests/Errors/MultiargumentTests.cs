

namespace ClayTests.Errors;

public class MultiargumentTests
{


    [Test]
    public void Test1() {
        Argument<object>.Throw();
        Assert.Pass();

        EntityNotFound.Throw();
    }
}