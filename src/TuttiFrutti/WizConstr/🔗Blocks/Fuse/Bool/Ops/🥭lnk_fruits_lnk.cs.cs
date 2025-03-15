namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Or_Fruit_Or<TSrc>(TSrc seed) : Lnk_Fruit_Lnk<TSrc, fuseFn.IDisjunct, fuseFn.IDisjunct>(seed);
public abstract class Or_Fruit_And<TSrc>(TSrc seed) : Lnk_Fruit_Lnk<TSrc, fuseFn.IDisjunct, fuseFn.IConjunct>(seed);
public abstract class And_Fruit_And<TSrc>(TSrc seed) : Lnk_Fruit_Lnk<TSrc, fuseFn.IConjunct, fuseFn.IConjunct>(seed);
public abstract class And_Fruit_Or<TSrc>(TSrc seed) : Lnk_Fruit_Lnk<TSrc, fuseFn.IConjunct, fuseFn.IDisjunct>(seed);
