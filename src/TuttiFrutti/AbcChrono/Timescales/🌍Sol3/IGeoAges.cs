using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3;
public interface IGeoAges : IMilleTenThousandsPlus, IApproximate<IMilleTenThousandsPlus, ushort>;

public interface IGeoAges_wAgo : IGeoAges, IBack<IGeoAges>;
