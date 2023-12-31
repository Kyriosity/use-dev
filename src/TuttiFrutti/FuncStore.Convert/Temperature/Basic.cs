using Math.Phys.Temperature.Convert;
using Meas.Units.Phys.Temperature;
using System.Numerics;

namespace FuncStore.Convert.Temperature;
public class Basic : IFuncStore<In>
{
    public Func<N, N> For<N>(In from, In to) where N : INumber<N> {
        if (from == to)
            return x => x;

        var available = direct<N>();
        if (available.ContainsKey((from, to)))
            return direct<N>()[(from, to)];

        // ToDesign: GET ALL WHERE LEFT IS from, and TO is right
        var onLeft = available.Keys.Where(x => x.from == from);
        var onRight = available.Keys.Where(x => x.to == to);

        return null;
    }

    private static IDictionary<(In from, In to), Func<N, N>> direct<N>() where N : INumber<N> {
        // ToDesign: as prop or type
        return new Dictionary<(In, In), Func<N, N>> {
            [(In.Celsius, In.Kelvin)] = UniNumeric.C2K<N>,
            [(In.Kelvin, In.Celsius)] = UniNumeric.K2C<N>,

            [(In.Celsius, In.Fahrenheit)] = UniNumeric.C2F<N>,
            [(In.Fahrenheit, In.Celsius)] = UniNumeric.F2C<N>
        };
    }
}

