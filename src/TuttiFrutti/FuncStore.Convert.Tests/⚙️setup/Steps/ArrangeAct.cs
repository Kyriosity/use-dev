using System.Numerics;

namespace FuncStore.Convert.Tests.Setup.Steps;

public abstract class ArrangeAct<TStore, TUnit> : Arrange<TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    protected IFuncStore<TUnit> _funcs = new FuncStoreStub<TUnit>();

    [OneTimeSetUp]
    public void FixtureSetup() { _funcs = new TStore(); }

    public void ConvertBackForth<N>((N val, TUnit unit) from, (N val, TUnit unit) to) where N : INumber<N> {
        var func = _funcs.For<N>(from.unit, to.unit);

        if (func is null)
            Assert.Inconclusive($"{_funcs}<{typeof(TUnit).Name}>({from}->{to}) not/available");
        else // ToDo: EVALUATE: FINE! | TOLERATED | FAIL
            Assert.That(func(from.val), Is.EqualTo(to.val).Within(1));
    }
}

