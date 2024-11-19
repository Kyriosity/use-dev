using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3;
public interface IAeon : IMilleCentiThousandsUnlim, IApproximate<IMilleCentiThousandsUnlim, ushort>;

public interface IAeon_wAgo : IAeon, IBack<IAeon>;
