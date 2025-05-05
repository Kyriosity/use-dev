using Abc.Logic.Fuse.Lazy;
using WizConstr.Blocks.Fuse.Bool.basal;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Pulp<T> : rightVoid<T>, INoLnkLeft;

public abstract class Lnk_Pulp<T, Lnk> : rightVoid<T>, ILnkLeftOnly
    where Lnk : IBool;

public abstract class Pulp_Lnk<T, Lnk> : Pulp_Lnk<T, bool, Lnk> where Lnk : IBool;

public abstract class Lnk_Pulp_Lnk<T, LnkLeft, Lnk> : Lnk_Pulp_Lnk<T, bool, LnkLeft, Lnk>
    where LnkLeft : IBool
    where Lnk : IBool;