using AbcExtNUnit.Attributes.Fixture;

namespace FuncStore.Convers.Tests.Setup.Metadata;

public class TestByAttribute<TStore>() : ParametrizedType<TStore, IFuncStore>()
    where TStore : IFuncStore, new();
