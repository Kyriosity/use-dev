using Mk.N_Val.Phys.Temperature.Math;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Conversions;
public class TemperatureFunctions<N> : FunctionalConversion<N, In> where N : INumber<N>
{
    protected static readonly N _NoffsetK2C = N.CreateChecked(Consts.KminusC);
    protected static readonly N _N32 = N.CreateChecked(32);

    private Dictionary<(In from, In to), Func<N, N>> _functions = new() {
        { (from: In.Celsius, to: In.Kelvin), x => N.CreateChecked(x + _NoffsetK2C) },
        { (from: In.Kelvin, to: In.Celsius), x => x - _NoffsetK2C },

        { (from: In.Fahrenheit, to: In.Celsius), x =>  N.CreateChecked(double.CreateChecked(x - _N32)  / 9 * 5)},
        { (from: In.Celsius, to: In.Fahrenheit), x =>  N.CreateChecked(double.CreateChecked(x) / 5  * 9) + _N32 },

        { (from: In.Fahrenheit, to: In.Kelvin), x =>  N.CreateChecked(double.CreateChecked(x - _N32) / 9 * 5) + _NoffsetK2C},
        { (from: In.Kelvin, to: In.Fahrenheit), x =>  N.CreateChecked((double.CreateChecked(x) - Consts.KminusC) / 5 * 9) + _N32  },
    };

    protected override Dictionary<(In from, In to), Func<N, N>> Functions => _functions;
}