namespace AbcChrono.Sol3.Scale;
public interface IHumanEra : ICentiMilleDecamille, IApproximate<ICentiMilleDecamille, ushort>;

public interface IHumanEra_wAgo : IHumanEra, IBack<IHumanEra>;

