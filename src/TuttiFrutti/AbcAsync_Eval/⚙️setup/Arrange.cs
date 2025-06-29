namespace AbcAsync_Eval.Setup;
public abstract class Arrange
{
    protected async Task<int> RunLongForAsync(ushort seconds) {
        await Task.Delay(1_000 * seconds);
        return seconds; // ToDo: cancellation and elapsed
    }
}
