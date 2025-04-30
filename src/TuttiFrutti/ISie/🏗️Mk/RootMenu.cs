namespace ISie.Mk;
internal abstract class RootMenu<T> : WizConstr.Core<T, bool> // ToDesign: CHANGE FOR GAPS
{
    internal RootMenu(T seed) {
        Seed = seed;
    }
}
