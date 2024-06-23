namespace ClayTest.KnowHow.Mutitask.AsyncAwait;
public class Reminder
{
    [Test]
    public async Task Simple() {

        //MainAsync().Wait();

        var res = await MemeAsync(7_000);
        var valTask = MemeAsync(7_000);

        var promise = await valTask;
    }

    public async Task SimpleValueTask() {
    }


    async Task<bool> MemeAsync(ushort msDelay) {
        await Task.Delay(msDelay);

        return true;
    }

    private void DoAsync(ushort msDelay) {
    }

    public static async Task MainAsync() {
        Task task1 = Task1();
        Task task2 = Task2();

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Finished main method");
    }

    public static async Task Task1() {
        await Task.Delay(5000);
        Console.WriteLine("Finished Task1");
    }

    public static async Task Task2() {
        await Task.Delay(10000);
        Console.WriteLine("Finished Task2");
    }
}
