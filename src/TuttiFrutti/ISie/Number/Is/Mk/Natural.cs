using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Mk;
public class Natural<N, PS> : Fruit<PS>, INatural
    where N : INumber<N> where PS : PolyStub<N>
{
    public bool PowOf2 => And(n => n.IsPow2());
    public bool Odd => And(n => N.IsOddInteger(n.Value));

    public bool Even => And(n => N.IsEvenInteger(n.Value));
}
