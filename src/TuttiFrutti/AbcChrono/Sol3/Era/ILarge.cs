namespace AbcChrono.Sol3.Era;
public interface ILarge : IYearCenti,
    IApproximate<IYearCenti, ushort>,
    IDated<IMonths_wShortcuts_wCa>;
