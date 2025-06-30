namespace ISie.Number.In.Mk;
public class Pluralizable<N, T> : WizConstr.Blocks.Fruit<Seed<N, T>, string>
    where N : INumber<N> where T : IScript
{
    public string Plural => Next(Seed.Plural());
}