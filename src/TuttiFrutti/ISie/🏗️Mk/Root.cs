namespace ISie.Mk;
internal abstract class Root<T> : WizConstr.Core<T, bool>
{
    internal Root(T seed) {
        Seed = seed;
    }
}