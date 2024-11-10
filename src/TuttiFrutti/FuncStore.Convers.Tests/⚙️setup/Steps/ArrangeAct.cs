namespace FuncStore.Convers.Tests.Setup.Steps;

public abstract class ArrangeAct<TStore, TUnit> : Arrange<TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    protected IFuncStore<TUnit> _funcware = new FuncStore<TUnit>();

    [OneTimeSetUp]
    public void FixtureSetup() { _funcware = new TStore(); }

}



