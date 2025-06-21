using AbcLingua.Rules.Numeric;

namespace ISie.Number.In.Mk;
public class Seed<N, T>(N num) : IRank where T : IScript where N : INumber<N>
{
    protected internal N Num => num;
    public bool Ordinal { get; set; } = false;
}