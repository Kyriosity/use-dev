namespace AbcChrono.Sol3.Era;
public interface IModern
    : IYearCenti_wShortcuts,
    IApproximate<IYearCenti_wShortcuts, ushort>,
    IDated;


public interface IYearCenti_wShortcuts
    : IYearCenti, IPresentShortcuts;