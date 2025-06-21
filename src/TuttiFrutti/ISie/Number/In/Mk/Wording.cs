namespace ISie.Number.In.Mk;
public class Wording<N, T> : WizConstr.Blocks.Fruit<Seed<N, T>, string>
    where T : IScript where N : INumber<N>
{
    protected override Func<Seed<N, T>, string> XForm =>
        seed => seed.Ordinal ? "ordinal" : "cardinal";
}
