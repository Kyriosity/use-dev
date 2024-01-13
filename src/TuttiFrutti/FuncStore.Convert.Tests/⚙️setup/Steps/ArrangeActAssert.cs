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
            Assert.Fail($"{nameof(Exception)}: \"{exception.Message}\"");
        }

        Assert.That(result, Is.EqualTo(expected).Within(delta ?? DefaultDelta));

        //    Assert.Pass($"{'\u25CF'} {'\u26AA'} {'\u26AB'} {'\u272A'}\n" +
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
}