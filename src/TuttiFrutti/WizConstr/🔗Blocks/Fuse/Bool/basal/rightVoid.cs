using Abc.Logic.Fuse;

namespace WizConstr.Blocks.Fuse.Bool.basal;

public abstract class rightVoid<T> : Fuse.basal.rightVoid<T, bool>
{
    protected virtual Lnk_Fruit<T, bool, IDisjunct> Or(Func<T, bool> xform) => Next<IDisjunct>(xform);
    protected virtual Lnk_Fruit<T, bool, IConjunct> And(Func<T, bool> xform) => Next<IConjunct>(xform);
    protected virtual Lnk_Fruit<T, bool, IExclude> Xor(Func<T, bool> xform) => Next<IExclude>(xform);
}