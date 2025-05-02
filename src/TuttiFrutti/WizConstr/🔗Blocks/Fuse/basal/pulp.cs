namespace WizConstr.Blocks.Fuse.basal;

public abstract class pulp<T, TRes> : Blocks.Pulp<T, TRes>
{
    protected override TRes Yield() {
        if (Prev is null)
            return XForm(Seed);

        Func<TRes> left = () => Prev.XForm(Prev.Seed);
        Func<TRes> right = () => XForm(Seed);

        var join = new[] { Prev.LnkRight, LnkLeft }.Single(fn => fn is not null);

        return join(left, right);
    }
}