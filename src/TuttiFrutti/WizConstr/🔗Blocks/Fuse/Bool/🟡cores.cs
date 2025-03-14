using Abc.Logic.Fuse;

namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc>(TSrc seed) : Core<TSrc, bool>(seed)
{
    // ToDo: GROUP ! INTO EXTENSION CLASS !
    public virtual Fruit<TSrc, bool> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    public virtual Fruit<TSrc, bool> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Fruit<TSrc, bool> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}

public abstract class Fn_Core<TSrc, Fn>(TSrc seed) : Fn_Core<TSrc, bool, Fn>(seed) where Fn : IBool
{
    // ToDo: GROUP !
    public virtual Fruit<TSrc, bool> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    //public virtual Fruit<TSrc, bool> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Fruit<TSrc, bool> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}

public abstract class Core_Fn<TSrc, Fn>(TSrc seed) : Core_Fn<TSrc, bool, Fn>(seed) where Fn : IBool;


public abstract class Fn_Core_Fn<TSrc, FnLeft, FnRight>(TSrc seed) : Fn_Core_Fn<TSrc, bool, FnLeft, FnRight>(seed)
    where FnLeft : IBool
    where FnRight : IBool;

