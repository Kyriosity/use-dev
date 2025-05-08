using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.basal;

public abstract class rightVoid<T, TRes> : pulp<T, TRes>, INoLnkRight
{
    protected new Blk Next<Blk>() where Blk :
        pulp<T, TRes>, ILnkLeft, new()
        =>
            base.Next<Blk>();

    protected Blk Next<Blk, Lnk>() where Blk : pulp<T, TRes>, INoLnkLeft, new()
        where Lnk : IBase<TRes> {

        var block = base.Next<Blk>();
        block.LnkLeft = Unpack<Lnk>();
        return block;
    }

    protected new Lnk_Fruit<T, TRes, Lnk> Next<Lnk>(Func<T, TRes> xform)
        where Lnk : IBase<TRes> =>
           new() { Seed = Seed, Prev = this, XForm = xform, Circuitry = Circuitry };
}