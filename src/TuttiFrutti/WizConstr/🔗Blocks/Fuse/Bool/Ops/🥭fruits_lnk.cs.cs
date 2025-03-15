namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Fruit_Or<TSrc>(TSrc seed) : Fruit_Lnk<TSrc, fuseFn.IDisjunct>(seed);
public abstract class Fruit_And<TSrc>(TSrc seed) : Fruit_Lnk<TSrc, fuseFn.IConjunct>(seed);
public abstract class Fruit_Xor<TSrc>(TSrc seed) : Fruit_Lnk<TSrc, fuseFn.IExclude>(seed);