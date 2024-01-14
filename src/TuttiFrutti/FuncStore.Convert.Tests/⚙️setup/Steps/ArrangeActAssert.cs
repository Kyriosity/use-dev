using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Steps;
public abstract class ArrangeActAssert<TStore, TUnit> : ArrangeAct<TStore, TUnit>
     where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    public virtual void Match<N>(N subject, TUnit subjUnit, N expected, TUnit expUnit, string name, string cat, double? delta)
        where N : INumber<N> {

        var func = _funcs.For<N>(subjUnit, expUnit);
        if (func is null)
            Assert.Ignore($"N/A: {_funcs} ({subjUnit}->{expUnit})");

        N result = default;
        try {
            result = func(subject);
        } catch (Exception exception) {
            Assert.Fail($"{nameof(Exception)}: \"{exception.Message}\"", "% '\u26AB'");
        }


        Assert.That(result, Is.EqualTo(expected).Within(delta ?? DefaultDelta));
        Assert.Pass(Assess(result - expected, delta ?? DefaultDelta));

        //    Assert.Pass($"{'\u25CF'} white circ {'\u26AA'} bl circ{'\u26AB'} \n" +
        //$" {'\u274D'} {'\u2B24'} {'\u2B55'} {'\u25D7'} {'\u25E0'} > {'\u25EF'} {'\u2B55'}\n" +
        //$"⭐ ⭐ {'\u25D2'} {'\u25D0'} {'\u2730'} {'\u2B50'}");
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

    private static string Assess<N>(N diff, double delta) where N : INumber<N> {
        const char _filled = '\u26AB';
        const char _voided = '\u26AA';
        const int scaleLen = 10;

        double precision = 1;
        if (diff != N.Zero) {
            diff = N.Zero > diff ? -diff : diff;
            precision = 1 - System.Math.Round(double.CreateChecked(diff) / delta, 2);
        }
        var filledLen = System.Convert.ToInt32(precision * scaleLen);
        var extraInfo = 1 == precision ? string.Empty : $" ({diff} within {delta})";
        return $"Precision: {precision * 100}%{extraInfo}\n{new string(_filled, filledLen)}{new string(_voided, scaleLen - filledLen)}";
    }
}