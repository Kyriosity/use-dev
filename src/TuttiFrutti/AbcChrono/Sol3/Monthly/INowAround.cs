namespace AbcChrono.Sol3.Monthly;
public interface INowAround
{
    string Today { get; }
    string TodayAdd(short addDays);
    string Tomorrow { get; }
    string Yesterday { get; }
}
