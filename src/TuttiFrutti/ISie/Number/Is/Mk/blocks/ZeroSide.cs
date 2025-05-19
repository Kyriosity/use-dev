using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Mk.blocks;
public class ZeroSide<N, PS> : Fruit<PS>, IZeroSide
    where N : INumber<N> where PS : PolyStub<N>
{
    public bool Positive => And(n => N.IsPositiveInfinity(n.Value));

    public bool Negative => And(n => N.IsNegativeInfinity(n.Value));
}
