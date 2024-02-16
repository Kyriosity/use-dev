using AbcExt.Xlat.Consts;
using Funcware.Numeric.SameType.InUnit.Custom;
using MeasUnits.Phys.Temperature;
using System.Numerics;

namespace MeasFuncware.Convert.Temperature;

public class FuncStoreMAPPERD<U> : IWire<U> where U : Enum
{
    // ToDo: IROUTER !

    public Func<N, N>? For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        if (from.Equals(to))
            return x => x;

        return null;
    }
}

public class AllAroundFuncStore<U> : Temperatures, IWire<U> where U : Enum
{
    public Func<N, N>? For<N>(U from, U to) where N : INumber<N> {
        //Enum.TryParse()
        var parsedA = Parse.Try(from, out In normFrom);
        var parsedB = Parse.Try(from, out In normTo);

        return base.For<N>(normFrom, normTo);
    }
}

public class Temperatures : FuncStore<In>
{
    protected override IDictionary<(In from, In to), Func<N, N>> FuncsBag<N>() =>
        new Dictionary<(In, In), Func<N, N>> {
            [(In.Celsius, In.Kelvin)] = x => x + Diff<N>(),
            [(In.Kelvin, In.Celsius)] = x => x - Diff<N>(),

            [(In.Celsius, In.Fahrenheit)] = x => N.CreateChecked((double.CreateChecked(x) / 5 * 9) + 32),
            [(In.Fahrenheit, In.Celsius)] = x => N.CreateChecked((double.CreateChecked(x) - 32) / 9 * 5),

            [(In.Rankine, In.Kelvin)] = x => N.CreateChecked(double.CreateChecked(x) / 9 * 5),
            [(In.Kelvin, In.Rankine)] = x => N.CreateChecked(double.CreateChecked(x) / 5 * 9),
        };

    private static N Diff<N>() where N : INumber<N> => N.CreateChecked(273.15);
}