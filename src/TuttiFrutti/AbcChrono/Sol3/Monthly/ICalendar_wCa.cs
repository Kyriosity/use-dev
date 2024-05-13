namespace AbcChrono.Sol3.Monthly;
public interface ICalendar_wCa<T> : ICalendar
    where T : ICalendar
{
    public T circa(short delta = 1);
}
