namespace WizConstr.Xform;

public abstract class Core<TSrc, TRes> : Core<TSrc>
{
    protected internal abstract TRes Eval();
    protected abstract TRes Yield();
}