using System.Numerics;

namespace N_Val;
public interface IConversion<N, U> where N : INumber<N> where U : Enum
{
    N Calculate(N value, U from, U to);
}