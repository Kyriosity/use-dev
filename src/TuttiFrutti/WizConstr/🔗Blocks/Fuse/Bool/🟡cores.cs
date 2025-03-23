using Abc.Logic.Fuse;
using WizConstr.Blocks.Fuse.Bool.basal;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc> : rightVoid<TSrc>, INoLnkLeft;

public abstract class Lnk_Core<TSrc, Lnk> : rightVoid<TSrc>, ILnkLeftOnly
    where Lnk : IBool
{
    //internal override Func<bool, bool, bool>? LnkLeft { get; set; } = Unpack<Lnk>(); // ToDelete: CHECK IF REMOVABLE !

}

public abstract class Core_Lnk<TSrc, Lnk> : Core_Lnk<TSrc, bool, Lnk> where Lnk : IBool;

public abstract class Lnk_Core_Lnk<TSrc, LnkLeft, Lnk> : Lnk_Core_Lnk<TSrc, bool, LnkLeft, Lnk>
    where LnkLeft : IBool
    where Lnk : IBool;