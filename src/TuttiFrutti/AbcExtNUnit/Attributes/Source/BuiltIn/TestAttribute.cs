namespace AbcExtNUnit.Attributes.Source.BuiltIn;

public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params string[] args)
    : TestCaseSourceAttribute(HardCodedMethodName, [SuppliedTypes, args])
{
    static IEnumerable<Type> SuppliedTypes => _suppliedTypes ??
        [.. _typeParameters.TakeWhile(x => x != _ofTypeStub)];

    private static readonly IEnumerable<Type>? _suppliedTypes = null;

    private static readonly Type[] _typeParameters = [ typeof(T1), typeof(T2), typeof(T3),
        typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) ];

    private static readonly Type _ofTypeStub = typeof(NotSupplied);

    // should be supplied through context/properties but can't because of NUnit issues:
    // e.g. - github.com/nunit/nunit/issues/548 -- still open in 2025
    protected const string HardCodedMethodName = "CompileTestSource";
}
