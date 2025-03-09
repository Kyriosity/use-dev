namespace WizConstr;

public abstract class Core<T>
{
    internal Core() {
        /// intentionally blank
    }

    protected abstract T Seed { get; init; }
}