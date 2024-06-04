namespace AbcChrono.Sol3.Era;

public interface ILong<Anni> :
    IYearCentiMille,
    IApproximate<IYearCentiMille, ushort>,
    IDated<Anni>

    where Anni : IAnnual;
