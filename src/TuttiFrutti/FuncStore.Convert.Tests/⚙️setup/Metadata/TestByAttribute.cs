namespace FuncStore.Convert.Tests.Setup.Metadata;

public class TestByAttribute<TStore>(params string[] _) : TestFixtureAttribute(_typeOfStore, _typeOfUnit)
    where TStore : IFuncStore, new()
{
    private static readonly Type _typeOfStore = typeof(TStore);

    private static readonly Type? _typeOfUnit = DeriveUnitArgument(_typeOfStore);

    private static Type? DeriveUnitArgument(Type type) {
        // ToDesign: exact match of interface
        var allFaces = _typeOfStore.GetInterfaces();
        var faces = _typeOfStore.GetInterfaces().Where(
            iface => iface.Name.StartsWith(nameof(IFuncStore)) && 0 < iface.GenericTypeArguments.Length);

        if (!faces.Any())
            Argument<IFuncStore>.Throw($"Generic \"{nameof(IFuncStore)}\" not implemented in {_typeOfStore}");

        var arg = faces.First().GenericTypeArguments.SingleOrDefault(x => x.BaseType?.Name == nameof(Enum));

        return arg ?? Argument<IFuncStore>.Throw($"\"{nameof(IFuncStore)}\" has no generic argument of type {nameof(Enum)}");
    }
}
