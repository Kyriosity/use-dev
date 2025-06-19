namespace ISie.Number.In;
public class InWords<N, T>(N seed) : WizConstr.Blocks.Fruit<Seed<N, T>, string> where T : IScript where N : INumber<N>
{
    public string Ordinal => null;
}