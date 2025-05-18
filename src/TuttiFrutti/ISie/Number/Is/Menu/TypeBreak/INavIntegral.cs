using ISie.Number.Is.Menu.Options;
using ISie.Number.Is.Mk;

namespace ISie.Number.Is.Menu.TypeBreak;
public interface INavIntegral<N, PS> : IIntegral
    where N : INumber<N> where PS : PolyStub<N>
{
    public Natural<N, PS> NaturalOr0 { get; }
}