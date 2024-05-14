namespace AbcChrono.Sol3.Era;
public interface IModern : IYearCenti,
    IApproximate<IYearCenti, ushort>,
    IDated<IMonths_wShortcuts_wCa>;
