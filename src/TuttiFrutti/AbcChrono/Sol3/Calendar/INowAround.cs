namespace AbcChrono.Sol3.Calendar;
public interface INowAround
{
    string Today { get; }
    string TodayAdd(short addDays);
    string Tomorrow { get; }
    string Yesterday { get; }
}

