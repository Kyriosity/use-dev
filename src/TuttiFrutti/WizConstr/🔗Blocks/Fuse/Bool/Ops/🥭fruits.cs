namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Fruit_Or<TSrc>(TSrc seed) : Fruit_Fn<TSrc, fuseFn.IDisjunct>(seed);
public abstract class Fruit_And<TSrc>(TSrc seed) : Fruit_Fn<TSrc, fuseFn.IConjunct>(seed);
public abstract class Fruit_Xor<TSrc>(TSrc seed) : Fruit_Fn<TSrc, fuseFn.IExclude>(seed);


public abstract class Or__Fruit<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IDisjunct>(seed);
public abstract class And_Fruit<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IConjunct>(seed);
public abstract class Xor_Fruit_Xor<TSrc>(TSrc seed) : Fn_Fruit<TSrc, fuseFn.IExclude>(seed);
