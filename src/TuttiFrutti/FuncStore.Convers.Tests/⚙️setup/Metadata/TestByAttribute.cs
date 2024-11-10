using AbcExtNUnit.Metadata.Shortcuts.Fixture;

namespace FuncStore.Convers.Tests.Setup.Metadata;

public class TestByAttribute<TStore>() : ParametrizedType<TStore, IFuncStore>()
    where TStore : IFuncStore, new();
