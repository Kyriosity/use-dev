using Abc.Logic.Fuse;
using WizConstr.Blocks.Fuse.Bool.basal;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Pulp<T> : rightVoid<T>, INoLnkLeft;

public abstract class Lnk_Pulp<TSrc, Lnk> : rightVoid<TSrc>, ILnkLeftOnly
    where Lnk : IBool
{
    //internal override Func<bool, bool, bool>? LnkLeft { get; set; } = Unpack<Lnk>(); // ToDelete: CHECK IF REMOVABLE !

}

public abstract class Pulp_Lnk<TSrc, Lnk> : Pulp_Lnk<TSrc, bool, Lnk> where Lnk : IBool;

public abstract class Lnk_Pulp_Lnk<TSrc, LnkLeft, Lnk> : Lnk_Pulp_Lnk<TSrc, bool, LnkLeft, Lnk>
    where LnkLeft : IBool
    where Lnk : IBool;