namespace FuncStore.Convert.Tests.Setup.Steps;
public abstract class ArrangeActAssert<TStore, TUnit> : ArrangeAct<TStore, TUnit>
     where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
}
