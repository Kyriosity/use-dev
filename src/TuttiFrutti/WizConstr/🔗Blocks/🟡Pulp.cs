namespace WizConstr.Blocks;

public abstract class Pulp<T, TRes> : Xform.Pulp<T, TRes>
{
    internal Pulp<T, TRes>? Prev { get; init; }

    protected abstract TRes Fuse();

    protected internal virtual TRes Yield() {
        var result = Prev is null ? XForm(Seed) : Fuse();

        // ToDesign: Circuitry here;

        return result;
    }


    protected new TBk Next<TBk>() where TBk : Pulp<T, TRes>, new() =>
    new() { Seed = Seed, Prev = this };

    protected TBk Next<TBk>(Func<T, TRes> xform) where TBk : Pulp<T, TRes>, new() {
        var pulp = Next<TBk>(); pulp.XForm = xform;

        return pulp;
    }
}