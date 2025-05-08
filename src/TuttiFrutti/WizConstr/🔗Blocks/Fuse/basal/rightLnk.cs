using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.basal;

public abstract class rightLnk<T, TRes, Lnk> : pulp<T, TRes>, ILnkRight
    where Lnk : IBase<TRes>
{
    internal override Func<TRes, Func<TRes>, TRes>? LnkRight { get; } = Unpack<Lnk>();

    protected new Blk Next<Blk>()
        where Blk : pulp<T, TRes>, INoLnkLeft, new()

        => base.Next<Blk>();

    protected new Blk Next<Blk>(Func<T, TRes> func)
      where Blk : pulp<T, TRes>, INoLnkLeft, new()

      => base.Next<Blk>(func);

    // ToDesign: move up to common use
    protected Fruit<T, TRes> Next(Func<T, TRes> xform) => new() { XForm = xform, Seed = Seed, Prev = this, Circuitry = Circuitry };
}