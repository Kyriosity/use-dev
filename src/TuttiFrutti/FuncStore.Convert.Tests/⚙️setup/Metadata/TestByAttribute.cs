using AbcExt.Errors.Sys;

namespace FuncStore.Conversion.Tests.Setup.Metadata;

public class TestByAttribute<TStore>(params string[] _) : TestFixtureAttribute(TypeOfStore, TypeOfUnit)
    where TStore : IFuncStore, new()
{
    private static readonly Type TypeOfStore = typeof(TStore);

    private static readonly Type? TypeOfUnit = DeriveUnitArgument(TypeOfStore);

    private static Type? DeriveUnitArgument(Type type) {
        var funcStoreInterfaces = TypeOfStore.GetInterfaces().Where(t => t.GetInterfaces().Any(b => b == typeof(IFuncStore)));
        if (!funcStoreInterfaces.Any())
            Argument<IFuncStore>.Throw($"`{TypeOfStore}` has no interface derived from {nameof(IFuncStore)}");

        var unitGenerics = funcStoreInterfaces.Where(iface => 0 < iface.GenericTypeArguments.Length)
            .SelectMany(x => x.GenericTypeArguments).Where(arg => arg.BaseType?.Name == nameof(Enum));

        var numUnitArgs = unitGenerics.Count();
        if (0 == numUnitArgs)
            Argument<IFuncStore>.Throw($"No generic argument refers units for \"{nameof(IFuncStore)}\"");
        if (1 < numUnitArgs)
            Argument<IFuncStore>.Throw($"More than one ({numUnitArgs}) generic \"{nameof(IFuncStore)}\" implemented in {TypeOfStore}");

        return unitGenerics.First();
    }
}
