namespace AbcChrono.Models;
public interface IBasal
{
    On Epoch { get; }
    bool IsCounterClock { get; internal set; }

    In Unit { get; internal set; }
}
