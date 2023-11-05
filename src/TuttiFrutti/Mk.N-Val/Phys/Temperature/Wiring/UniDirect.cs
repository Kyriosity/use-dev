using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Wiring;

public class UniDirect : IFuncStore<In>
{

    public Func<N, N> For<N>(In from, In to) where N : INumber<N> {
        if (from == to)
            return x => x;

        var aaa = typeof(N);

        if (In.Kelvin == from) {
            if (In.Celsius == to)
                return Linears.K2C<N>;
            if (In.Fahrenheit == to)
                return Linears.K2F<N>;
        }
        else if (In.Celsius == from) {
            if (In.Kelvin == to)
                return Linears.C2K<N>;
            if (In.Fahrenheit == to)
                return Linears.C2F<N>;
        }
        else if (In.Fahrenheit == from) {
            if (In.Kelvin == to)
                return Linears.F2K<N>;
            if (In.Celsius == to)
                return Linears.F2C<N>;
        }

        throw new NotSupportedException($"{from} - {to}");
    }
}