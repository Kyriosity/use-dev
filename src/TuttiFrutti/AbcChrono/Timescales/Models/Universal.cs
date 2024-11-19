namespace AbcChrono.Timescales.Models;
class Universal : IBasal
{
    public required On Epoch { get; init; }

    public bool IsCounterClock { get; set; } = false;
    public In Unit { get; set; }
}
