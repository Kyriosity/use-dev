using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3.Era;

public interface ILong<Anni> :
    IYearCentiMille,
    IApproximate<IYearCentiMille, ushort>,
    IDated<Anni>

    where Anni : IAnnual;
