namespace AbcExtNUnit.Metadata.Shortcuts.Fixture;

public abstract class ParametrizedType<T, TargetInterface>(params string[] args)
    : TestFixtureAttribute([TypeOfT, .. DeriveInterfaceParameters(), .. args])
{
    private static readonly Type TypeOfT = typeof(T);

    private static Type[] DeriveInterfaceParameters() {
        var targetType = typeof(TargetInterface);

        var targetInterfaces = TypeOfT.GetInterfaces().Where(t => t.GetInterfaces()
            .Any(b => b == targetType)).ToList();

        if (targetInterfaces.Count is 0)
            Argument.Throw($"`{TypeOfT}` has no interface derived from \"{targetType.Name}\"");

        var interfaceParameters = targetInterfaces.Where(x => 0 < x.GenericTypeArguments.Length)
            .SelectMany(x => x.GenericTypeArguments).Where(arg => arg.BaseType?.Name == nameof(Enum))
            .ToList();

        if (interfaceParameters.Count is 0)
            Argument.Throw($"No generic parameter for \"{targetType.Name}\"");

        return [.. interfaceParameters];
    }
}
