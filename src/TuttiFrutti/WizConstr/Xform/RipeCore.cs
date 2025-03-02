namespace WizConstr.Xform;

public abstract class RipeCore<TSeed, TRes> : Core<TSeed, TRes>
{
    public static implicit operator TRes(RipeCore<TSeed, TRes> source) => source.Result();

    // APPLY XFORM
}
