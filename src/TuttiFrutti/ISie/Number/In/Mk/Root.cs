namespace ISie.Number.In.Mk;
public class Root<N, T> : Wording<N, T>
    where N : INumber<N> where T : IScript
{
    public Root(N seed) {
        Seed = new Seed<N, T>(seed);
    }

    public string Ordinal => Next<Wording<N, T>>(); // ToDesign: Ordinal = true;
}