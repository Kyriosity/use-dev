namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Fruit_Or<T> : Fruit_Lnk<T, fuseFn.IDisjunct>;
public abstract class Fruit_And<T> : Fruit_Lnk<T, fuseFn.IConjunct>;
public abstract class Fruit_Xor<T> : Fruit_Lnk<T, fuseFn.IExclude>;