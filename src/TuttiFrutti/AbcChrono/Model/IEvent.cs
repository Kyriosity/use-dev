namespace AbcChrono.Model;
public interface IEvent : IBasal
{
    byte? DayNr { get; set; }
    Month Month { get; set; }
}
