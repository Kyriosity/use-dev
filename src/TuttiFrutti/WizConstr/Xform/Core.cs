namespace WizConstr.Xform;

public abstract class Core<TSrc, TRes> : Core<TSrc>
{
    internal abstract TRes Eval();
    protected abstract TRes Yield();
}