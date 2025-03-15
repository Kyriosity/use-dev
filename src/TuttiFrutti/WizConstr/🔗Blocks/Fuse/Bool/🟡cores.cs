using Abc.Logic.Fuse;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc>(TSrc seed) : Core<TSrc, bool>(seed)
{
    public virtual Fruit<TSrc, bool> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    public virtual Fruit<TSrc, bool> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Fruit<TSrc, bool> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}

public abstract class Lnk_Core<TSrc, Lnk>(TSrc seed) : Lnk_Core<TSrc, bool, Lnk>(seed) where Lnk : IBool
{
    // ToDo: GROUP ! INHERIT FROM CORE !
    public virtual Fruit<TSrc, bool> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    public virtual Fruit<TSrc, bool> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Fruit<TSrc, bool> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}

public abstract class Core_Lnk<TSrc, Lnk>(TSrc seed) : Core_Lnk<TSrc, bool, Lnk>(seed) where Lnk : IBool;


public abstract class Lnk_Core_Lnk<TSrc, LnkLeft, Lnk>(TSrc seed) : Lnk_Core_Lnk<TSrc, bool, LnkLeft, Lnk>(seed)
    where LnkLeft : IBool
    where Lnk : IBool;
