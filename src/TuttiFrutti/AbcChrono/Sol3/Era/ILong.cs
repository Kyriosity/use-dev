namespace AbcChrono.Sol3.Era;
public interface ILong : IYearCentiMille,
    IApproximate<IYearCentiMille, ushort>,
    IDated<IMonths_wCa<IMonths>>;
