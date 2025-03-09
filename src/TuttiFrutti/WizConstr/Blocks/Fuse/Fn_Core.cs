
namespace WizConstr.Blocks.Fuse;

public abstract class Fn_Core<TSrc, TRes>(TSrc seed) : Core<TSrc, TRes>(seed), IRightVoid, IApplyRight;
