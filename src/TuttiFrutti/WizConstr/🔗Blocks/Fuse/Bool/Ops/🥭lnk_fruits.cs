using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Or_Fruit<T> : Lnk_Fruit<T, IDisjunct>;
public abstract class And_Fruit<T> : Lnk_Fruit<T, IConjunct>;
//public abstract class Xor_Fruit<T> : Lnk_Fruit<T, IExclude>;
