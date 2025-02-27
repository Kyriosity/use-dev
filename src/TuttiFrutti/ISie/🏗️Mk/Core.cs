namespace ISie.Mk;

public abstract class Core<T>
{
    public T Value { get; init; } = NotSet.Throw();

    protected IList<Func<bool>> _ops = [];

    // LIST of OPs and CONDITIONS
    protected int Circuitry { get; init; }

    internal S Next<S>() where S : Core<T>, new() {
        var next = new S { Value = Value, Circuitry = Circuitry };
        // ToDo: copy core
        return next;
    }
}

public abstract class RipeCode<T> : Core<T>
{
    public static implicit operator bool(RipeCode<T> source) => source.Result();

    protected bool Result() {
        if (!_ops.Any())
            NotImplemented.Throw("no operation supplied");

        var res = true;
        foreach (var op in _ops) {
            res = op();
        }

        return res;
    }
}