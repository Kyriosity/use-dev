using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Wiring;

public class Default : IFuncStore<In>
{
    public Func<N, N> For<N>(In from, In to) where N : INumber<N> {
        if (from == to)
            return x => x;

        if (In.Kelvin == from) {
            if (In.Celsius == to)
                return UniLinears.K2C<N>;
            if (In.Fahrenheit == to)
                return UniLinears.K2F<N>;
        }
        else if (In.Celsius == from) {
            if (In.Kelvin == to)
                return UniLinears.C2K<N>;
            if (In.Fahrenheit == to)
                return UniLinears.C2F<N>;
        }
        else if (In.Fahrenheit == from) {
            if (In.Kelvin == to)
                return UniLinears.F2K<N>;
            if (In.Celsius == to)
                return UniLinears.F2C<N>;
        }

        throw new NotSupportedException($"{from} - {to}");
    }
}