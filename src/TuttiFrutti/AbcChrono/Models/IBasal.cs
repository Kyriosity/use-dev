namespace AbcChrono.Models;
public interface IBasal
{
    Scale Epoch { get; }
    bool IsCounterClock { get; internal set; }

    In Unit { get; internal set; }
}
