using AbcLingua.Rules.Numeric;

namespace ISie.Number.In.Mk;
public class Seed<N, T>(N num) : IRank_Edit where T : IScript where N : INumber<N>
{
    protected internal N Num => num;
    public bool IsOrdinal { get; set; } = false;
}
