namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Or_Fruit<T> : Lnk_Fruit<T, fuseFn.IDisjunct>;
public abstract class And_Fruit<T> : Lnk_Fruit<T, fuseFn.IConjunct>;
public abstract class Xor_Fruit<T> : Lnk_Fruit<T, fuseFn.IExclude>;
