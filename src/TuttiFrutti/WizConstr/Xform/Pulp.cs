using AbcStoppers.Errors.Data;
namespace WizConstr.Xform;

public abstract class Pulp<T, TRes> : Core<T, TRes>
{
    protected internal virtual Func<T, TRes> XForm {
        get => _eval ??
            NotSet.Throw($"{GetType().Name}.{nameof(XForm)}");
        set => _eval = value;
    }
    private Func<T, TRes>? _eval = null;

    protected virtual TRes Result => XForm(Seed);

    protected internal TRes Yield(bool isInterim = false) =>
        isInterim || Circuitry is null ? Result : Circuitry(Result);

    public override string ToString() => Yield().ToString();
}