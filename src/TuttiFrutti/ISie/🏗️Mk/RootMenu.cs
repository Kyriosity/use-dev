namespace ISie.Mk;
internal abstract class RootMenu<T> : WizConstr.Core<T, bool>
{
    internal RootMenu(T seed) {
        Seed = seed;
    }
}
