using Abc.Ext.Glyphs;
using System.Numerics;

namespace FuncStore.Conversion.Tests.Setup.Steps;
public abstract class ArrangeActAssert<TStore, TUnit> : ArrangeAct<TStore, TUnit>
     where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    public virtual void Match<N>(N subject, TUnit subjUnit, N expected, TUnit expUnit,
        string name, string cat, double? delta) where N : INumber<N> {

        var func = _funcs.For<N>(subjUnit, expUnit);
        if (func is null)
            Assert.Ignore($"N/A: {_funcs} ({subjUnit}->{expUnit})");

        N result = N.Zero;
        try {
            result = func(subject);
        } catch (Exception exception) {
            // math throws System.Exception - no way to sort
            Assert.Fail($"{Nature.HighVoltage} {exception.Message}");
        }

        var tolerance = delta ?? DefaultDelta; var diff = result - expected;
        Assert.That(result, Is.EqualTo(expected).Within(tolerance));
        Assert.Pass(ScaleAssess(result - expected, tolerance));
    }

    public virtual void Mismatch<N>() {
        // ToDo: 
    }

    public virtual void MissFunc<N>(TUnit from, TUnit to) where N : INumber<N> {
        var func = _funcs.For<N>(from, to);

        Assert.That(func, Is.Null, $"{from}->{to} must be not avaiable but found");
    }

    public virtual void ResultException<T>() where T : Exception {
        // ToDo: Assert.Throws<T>() { }
    }

    private static string ScaleAssess<N1, N2>(N1 diff, N2 range) where N1 : INumber<N1> where N2 : INumber<N2> {
        const int scaleLen = 12;
        var absDiff = N1.Zero > diff ? -diff : diff;

        double precision = diff == N1.Zero ? 1 :
            1 - Math.Round(double.CreateChecked(absDiff) / double.CreateChecked(range), 2);
        var filledLen = Convert.ToInt32(precision * scaleLen);
        var extraInfo = 1 == precision ? string.Empty : $" ({absDiff} within {range})";
        return $"Precision: {precision * 100}%{extraInfo}\n{new string(Stars.WhiteCircled, filledLen)}{new string(Stars.WhiteShadowed, scaleLen - filledLen)}";
    }
}