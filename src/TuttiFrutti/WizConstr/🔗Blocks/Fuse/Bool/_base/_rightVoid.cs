using Abc.Logic.Fuse;

namespace WizConstr.Blocks.Fuse.Bool._base;

public abstract class _rightVoid<TSrc>(TSrc seed) : Fuse._base._rightVoid<TSrc, bool>(seed)
{
    public virtual Fruit<TSrc, bool> Or(Func<TSrc, bool> xform) => Next<IDisjunct>(xform);
    public virtual Fruit<TSrc, bool> And(Func<TSrc, bool> xform) => Next<IConjunct>(xform);
    public virtual Fruit<TSrc, bool> Xor(Func<TSrc, bool> xform) => Next<IExclude>(xform);
}
