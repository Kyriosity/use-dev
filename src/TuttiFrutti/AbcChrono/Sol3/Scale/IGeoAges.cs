namespace AbcChrono.Sol3.Scale;
public interface IGeoAges : IMilleTenThousandsPlus, IApproximate<IMilleTenThousandsPlus, ushort>;

public interface IGeoAges_wAgo : IGeoAges, IBack<IGeoAges>;
