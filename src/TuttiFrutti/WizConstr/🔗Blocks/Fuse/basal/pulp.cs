namespace WizConstr.Blocks.Fuse.basal;

public abstract class pulp<T, TRes> : Blocks.Pulp<T, TRes>
{

    protected override TRes Yield() =>
        Prev is null ? XForm(Seed) : new[] { Prev.LnkRight, LnkLeft }.Single(fn => fn is not null)
          (Prev.XForm(Prev.Seed), XForm(Seed));
}