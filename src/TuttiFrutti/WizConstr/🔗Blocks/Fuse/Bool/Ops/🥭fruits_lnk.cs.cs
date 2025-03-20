namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Fruit_Or<TSrc> : Fruit_Lnk<TSrc, fuseFn.IDisjunct>;
public abstract class Fruit_And<TSrc> : Fruit_Lnk<TSrc, fuseFn.IConjunct>;
public abstract class Fruit_Xor<TSrc> : Fruit_Lnk<TSrc, fuseFn.IExclude>;