namespace AbcChrono.Models;
public interface IBasal
{
    At Epoch { get; }
    bool IsCounterClock { get; internal set; }

    In Unit { get; internal set; }
}
