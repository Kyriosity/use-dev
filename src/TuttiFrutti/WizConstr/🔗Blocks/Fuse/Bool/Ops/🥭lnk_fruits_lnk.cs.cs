namespace WizConstr.Blocks.Fuse.Bool.Ops;
public abstract class Or_Fruit_Or<TSrc> : Lnk_Fruit_Lnk<TSrc, fuseFn.IDisjunct, fuseFn.IDisjunct>;
public abstract class Or_Fruit_And<TSrc> : Lnk_Fruit_Lnk<TSrc, fuseFn.IDisjunct, fuseFn.IConjunct>;
public abstract class And_Fruit_And<TSrc> : Lnk_Fruit_Lnk<TSrc, fuseFn.IConjunct, fuseFn.IConjunct>;
public abstract class And_Fruit_Or<TSrc> : Lnk_Fruit_Lnk<TSrc, fuseFn.IConjunct, fuseFn.IDisjunct>;
