namespace WizConstr.Xform;

public interface IXFormFuncd<TSrc, TRes>
{
    Func<TSrc, TRes> Xform { get; init; }
}
