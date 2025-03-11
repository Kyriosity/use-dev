namespace WizConstr;

public abstract class Core<T>
{
    internal Core() {
        // intentionally blank
    }

    protected T? Seed { get; init; }
}