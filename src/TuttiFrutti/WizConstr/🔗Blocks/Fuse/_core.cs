namespace WizConstr.Blocks.Fuse;

public abstract class _core<TSrc, TRes>(TSrc seed) : Blocks.Core<TSrc, TRes>(seed)
{
    protected override TRes Yield() {
        throw new NotImplementedException(); // ToDo: VALUE by CHAIN
    }
}