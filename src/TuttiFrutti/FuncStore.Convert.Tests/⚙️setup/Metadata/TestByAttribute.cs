namespace FuncStore.Conversion.Tests.Setup.Metadata;

public class TestByAttribute<TStore>(params string[] _) : TestFixtureAttribute(_typeOfStore, _typeOfUnit)
    where TStore : IFuncStore, new()
{
    private static readonly Type _typeOfStore = typeof(TStore);

    private static readonly Type? _typeOfUnit = DeriveUnitArgument(_typeOfStore);

    private static Type? DeriveUnitArgument(Type type) {
        var funcStoreInterfaces = _typeOfStore.GetInterfaces().Where(t => t.GetInterfaces().Any(b => b == typeof(IFuncStore)));
        if (!funcStoreInterfaces.Any())
            Argument<IFuncStore>.Throw($"`{_typeOfStore}` has no interface derived from {nameof(IFuncStore)}");

        var unitGenerics = funcStoreInterfaces.Where(iface => 0 < iface.GenericTypeArguments.Length)
            .SelectMany(x => x.GenericTypeArguments).Where(arg => arg.BaseType?.Name == nameof(Enum));

        var numUnitArgs = unitGenerics.Count();
        if (0 == numUnitArgs)
            Argument<IFuncStore>.Throw($"No generic argument refers units for \"{nameof(IFuncStore)}\"");
        if (1 < numUnitArgs)
            Argument<IFuncStore>.Throw($"More than one ({numUnitArgs}) generic \"{nameof(IFuncStore)}\" implemented in {_typeOfStore}");

        return unitGenerics.First();
    }
}
