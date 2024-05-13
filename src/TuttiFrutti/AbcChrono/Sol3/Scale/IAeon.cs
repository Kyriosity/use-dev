namespace AbcChrono.Sol3.Scale;
public interface IAeon : IMilleCentiThousandsUnlim, IApproximate<IMilleCentiThousandsUnlim, ushort>;

public interface IAeon_wAgo : IAeon, IBack<IAeon>;
