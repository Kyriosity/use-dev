using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Steps;
public abstract class ArrangeActAssert<TStore, TUnit> : ArrangeAct<TStore, TUnit>
     where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    public virtual void Compare<N>((N val, TUnit unit) left, (N val, TUnit unit) right,
        string name, string cat = "", string @class = "") where N : INumber<N> {

        var func = _funcs.For<N>(left.unit, right.unit);
        if (func is null)
            Assert.Ignore($"N/A: {_funcs} ({left.unit}->{right.unit})");

        N result = default;
        try {
            result = func(left.val);
        } catch (Exception exception) {
            Assert.Fail($"{nameof(Exception)}: \"{exception.Message}\"");
        }

        Assert.That(result, Is.EqualTo(right.val));

        //    Assert.Pass($"{'\u25CF'} {'\u26AA'} {'\u26AB'} {'\u272A'}\n" +
        //$" {'\u274D'} {'\u2B24'} {'\u2B55'} {'\u25D7'} {'\u25E0'} > {'\u25EF'} {'\u2B55'}\n" +
        //$"⭐ ⭐ {'\u25D2'} {'\u25D0'} {'\u2730'} {'\u2B50'}");
    }

    public virtual void ProveNotAvailable<N>(TUnit from, TUnit to) where N : INumber<N> {
        var func = _funcs.For<N>(from, to);

        Assert.That(func, Is.Null, $"{from}->{to} must be not/avaiable");
    }
}
