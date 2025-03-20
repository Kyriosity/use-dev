namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Or_Fruit<TSrc> : Lnk_Fruit<TSrc, fuseFn.IDisjunct>;
public abstract class And_Fruit<TSrc> : Lnk_Fruit<TSrc, fuseFn.IConjunct>;
public abstract class Xor_Fruit<TSrc> : Lnk_Fruit<TSrc, fuseFn.IExclude>;
