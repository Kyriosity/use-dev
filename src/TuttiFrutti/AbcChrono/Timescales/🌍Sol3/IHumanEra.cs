using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3;
public interface IHumanEra : ICentiMilleDecamille, IApproximate<ICentiMilleDecamille, ushort>;

public interface IHumanEra_wAgo : IHumanEra, IBack<IHumanEra>;

