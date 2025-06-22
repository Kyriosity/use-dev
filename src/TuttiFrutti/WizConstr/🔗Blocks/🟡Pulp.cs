namespace WizConstr.Blocks;

public abstract class Pulp<T, TRes> : Xform.Pulp<T, TRes>
{
    internal Pulp<T, TRes>? Prev { get; init; }

    protected TBk Next<TBk>() where TBk : Pulp<T, TRes>, new() =>
        new() { Seed = Seed, Circuitry = Circuitry, Prev = this };

    protected new TBk Next<TBk>(Func<T, TRes> xform) where TBk : Pulp<T, TRes>, new() {
        var pulp = Next<TBk>();
        pulp.XForm = xform;

        return pulp;
    }

    protected new TBk Next<TBk>(T seed) where TBk : Pulp<T, TRes>, new() {
        var pulp = Next<TBk>();
        pulp.XForm = XForm;
        pulp.Seed = seed;

        return pulp;
    }

    protected new Fruit<T, TRes> Next(T seed) =>
        Next<Fruit<T, TRes>>(seed);
}