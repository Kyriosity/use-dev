namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Or_Fruit<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IDisjunct>(seed);
public abstract class And_Fruit<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IConjunct>(seed);
public abstract class Xor_Fruit<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IExclude>(seed);
