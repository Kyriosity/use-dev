namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Fruit<TSrc>(TSrc seed) : Core<TSrc>(seed)
{
    public static implicit operator bool(Fruit<TSrc> source) => source.Yield();
}