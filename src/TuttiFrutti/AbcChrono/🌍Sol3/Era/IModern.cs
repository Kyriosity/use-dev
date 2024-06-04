namespace AbcChrono.Sol3.Era;
public interface IModern<Anni>
    : IYearCenti_wShortcuts,
    IApproximate<IYearCenti_wShortcuts, ushort>,
    IDated<Anni>
    where Anni : IAnnual;


public interface IYearCenti_wShortcuts
    : IYearCenti, IPresentShortcuts;