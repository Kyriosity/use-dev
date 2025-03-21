namespace WizConstr.Xform;
public interface IXFormSet<TSrc, TRes>
{
    Func<TSrc, TRes> Xform { get; init; }
}
