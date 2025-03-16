using Abc.Logic.Fuse;
using WizConstr.Blocks.Fuse.Bool._base;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc>(TSrc seed) : _rightVoid<TSrc>(seed), INoLnkLeft;

public abstract class Lnk_Core<TSrc, Lnk>(TSrc seed) : _rightVoid<TSrc>(seed), ILnkLeftOnly
    where Lnk : IBool
{
    internal override Type? LnkLeft { get; set; } = typeof(Lnk);
}

public abstract class Core_Lnk<TSrc, Lnk>(TSrc seed) : Core_Lnk<TSrc, bool, Lnk>(seed) where Lnk : IBool;

public abstract class Lnk_Core_Lnk<TSrc, LnkLeft, Lnk>(TSrc seed) : Lnk_Core_Lnk<TSrc, bool, LnkLeft, Lnk>(seed)
    where LnkLeft : IBool
    where Lnk : IBool;