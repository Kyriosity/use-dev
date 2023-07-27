using N_Val;
using System.Numerics;

namespace Mk.N_Val;
public class FunctionalConversion<N, U> : IConversion<N, U> where N : INumber<N> where U : Enum
{
    protected virtual Dictionary<(U from, U to), Func<N, N>> Functions => new();

    public virtual N Calculate(N value, U from, U to) => from.Equals(to) ? value : Functions[(from, to)](value);
}