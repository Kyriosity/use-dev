namespace WizConstr.Blocks.Fuse.Bool.Ops;
public abstract class Or_Fruit_Or<T> : Lnk_Fruit_Lnk<T, fuseFn.IDisjunct, fuseFn.IDisjunct>;
public abstract class Or_Fruit_And<T> : Lnk_Fruit_Lnk<T, fuseFn.IDisjunct, fuseFn.IConjunct>;
public abstract class And_Fruit_And<T> : Lnk_Fruit_Lnk<T, fuseFn.IConjunct, fuseFn.IConjunct>;
public abstract class And_Fruit_Or<T> : Lnk_Fruit_Lnk<T, fuseFn.IConjunct, fuseFn.IDisjunct>;
