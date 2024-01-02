namespace FuncStore.Convert.Tests.Setup.Steps;

public abstract class ArrangeAct<TStore, TUnit> : Arrange<TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    protected IFuncStore<TUnit> _funcs = new FuncStoreStub<TUnit>();

    [OneTimeSetUp]
    public void FixtureSetup() { _funcs = new TStore(); }

}



