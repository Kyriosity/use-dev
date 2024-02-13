using AbcExtNUnit.Metadata.Shortcuts.Fixture;

namespace FuncStore.Conversion.Tests.Setup.Metadata;

public class TestByAttribute<TStore>() : ParametrizedType<TStore, IFuncStore>()
    where TStore : IFuncStore, new();
