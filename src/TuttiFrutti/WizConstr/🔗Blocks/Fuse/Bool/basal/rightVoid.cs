﻿using Abc.Logic.Fuse;

namespace WizConstr.Blocks.Fuse.Bool.basal;

public abstract class rightVoid<TSrc> : Fuse.basal.rightVoid<TSrc, bool>
{
    public virtual Lnk_Fruit<TSrc, bool, IDisjunct> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    public virtual Lnk_Fruit<TSrc, bool, IConjunct> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Lnk_Fruit<TSrc, bool, IExclude> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}
