namespace AbcChrono.Sol3.Calendar;
public interface IMonths_wCa<T> : IMonths
    where T : IMonths
{
    public T circa(short delta = 1);
}
