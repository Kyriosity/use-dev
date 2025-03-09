namespace WizConstr.Xform;

public abstract class Core<TSrc, TRes> : Core<TSrc>
{
    protected abstract TRes Eval(TSrc source);
    protected abstract TRes Yield();
}