namespace AbcAsync_Eval;

public class Demo : Setup.Arrange
{
    [Test]
    public void Test1() {
        var a = 5;
        var c = -11;

        (a, c) = (c, a);
        // Method1();
    }

    async void Method1() {
        var task = RunLongForAsync(5);

        var status = task.Status;

        int result = await task;
    }
}