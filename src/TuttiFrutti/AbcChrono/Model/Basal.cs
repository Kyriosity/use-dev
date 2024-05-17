namespace AbcChrono.Model;
class Event : IEvent
{
    public required Scale Epoch { get; init; }
    public byte? DayNr { get; set; }
    public Month Month { get; set; } = Month.Undefined;
}
