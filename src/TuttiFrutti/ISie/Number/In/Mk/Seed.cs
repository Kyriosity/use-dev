using Quantity = AbcLingua.Rules.Grammar.Quantity;
using Rank = AbcLingua.Rules.Numbers.Rank;
namespace ISie.Number.In.Mk;
public class Seed<N, T>(N num) : Rank.IEdit, Quantity.IEdit where T : IScript where N : INumber<N>
{
    protected internal N Num => num;
    public Rank.Values Rank { get; set; }
    public Quantity.Values Quantity { get; set; }
}
