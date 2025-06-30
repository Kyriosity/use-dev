using AbcLingua.Rules.Numbers.Rank;

namespace ISie.Number.In.Mk;
public class Seed<N, T>(N num) : IEdit where T : IScript where N : INumber<N>
{
    protected internal N Num => num;
    public Values Rank { get; set; }
}
