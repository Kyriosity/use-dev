using MeasUnits.Phys.Temperature;

namespace FuncStore.Conversion.Temperature;
public class Basic<U> : IFuncStore<U> where U : Enum
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
        if (from.Equals(to))
            return x => x;

        var available = direct<N>();
        //if (available.ContainsKey((from, to)))
        //    return direct<N>()[(from, to)];

        //// ToDesign: GET ALL WHERE LEFT IS from, and TO is right
        // var onLeft = available.Keys.Where(x => x.from == from);
        // var onRight = available.Keys.Where(x => x.to == to);

        return null;
    }

    private static IDictionary<(In from, In to), Func<N, N>> direct<N>() where N : INumber<N> {

        if (typeof(N) == typeof(double)) {

        }
        else {
        }

        // ToDesign: as prop or type
        // ToDesign: as extendable for other T units classified by num type!
        return new Dictionary<(In, In), Func<N, N>> {

            // ToDo: restore functions or switch other project instead !!!

            //[(In.Celsius, In.Kelvin)] = UniNumeric.C2K<N>,
            //[(In.Kelvin, In.Celsius)] = UniNumeric.K2C<N>,

            //[(In.Celsius, In.Fahrenheit)] = UniNumeric.C2F<N>,
            //[(In.Fahrenheit, In.Celsius)] = UniNumeric.F2C<N>
        };
    }
}

