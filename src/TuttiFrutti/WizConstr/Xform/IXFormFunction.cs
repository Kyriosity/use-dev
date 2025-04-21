namespace WizConstr.Xform;

public interface IXFormFunction<TSrc, TRes>
{
    Func<TSrc, TRes> Xform { get; init; }
}
