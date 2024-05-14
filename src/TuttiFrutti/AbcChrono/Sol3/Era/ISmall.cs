namespace AbcChrono.Sol3.Era;
public interface ISmall : IYearCentiMille,
    IApproximate<IYearCentiMille, ushort>,
    IDated<IMonths_wCa<IMonths>>;
