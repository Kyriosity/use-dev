using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Mk.blocks;
public class Integral<N, PS> : Fruit<PS>, IIntegral
    where N : INumber<N> where PS : PolyStub<N>
{
    public bool Odd => And(n => N.IsOddInteger(n.Value));

    public bool Even => And(n => N.IsEvenInteger(n.Value));
}