namespace ISie.Number.In.Mk;

public class Root<N, T> : WizConstr.Blocks.Fruit<Seed<N, T>, string>
    where N : INumber<N> where T : IScript
{
    public Root(N seed) {
        Seed = new Seed<N, T>(seed);
    }

    protected override Func<Seed<N, T>, string> XForm =>
        seed => seed.Rank.ToString(); // ToDo: PLACEHOLDER FOR CALL

    public string Ordinal => Next<Pluralizable<N, T>>(Seed.Ordinal());
}