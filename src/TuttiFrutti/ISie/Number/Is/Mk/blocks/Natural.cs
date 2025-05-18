using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Mk.blocks;
public class Natural<N, PS> : Integral<N, PS>, INatural
    where N : INumber<N> where PS : PolyStub<N>
{
    public bool PowOf2 => And(n => n.IsPow2());
}
