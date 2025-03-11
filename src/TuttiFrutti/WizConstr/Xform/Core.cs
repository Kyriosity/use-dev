namespace WizConstr.Xform;

public abstract class Core<TSrc, TRes> : Core<TSrc>
{
    protected abstract TRes Eval();
    protected abstract TRes Yield();
}