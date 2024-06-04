namespace AbcChrono;
public interface IDated<Anni>
    where Anni : IAnnual
{
    IMonths_wCa<Anni> At { get; } // ToDiff:
}
