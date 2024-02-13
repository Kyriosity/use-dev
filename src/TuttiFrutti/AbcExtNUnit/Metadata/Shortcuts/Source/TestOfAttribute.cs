namespace AbcExtNUnit.Metadata.Shortcuts.Source;
public class TestOfAttribute<T>(params string[] args) : TestOfAttribute<T, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2>(params string[] args) : TestOfAttribute<T1, T2, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3>(params string[] args) : TestOfAttribute<T1, T2, T3, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, Stubs.Basic>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Stubs.Basic>(args) { }

public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params string[] args)
    : TestCaseSourceAttribute(HardCodedMethodName, new object[] { SuppliedTypes, args })
{
    static IEnumerable<Type> SuppliedTypes => _suppliedTypes ?? _typeParameters
        .TakeWhile(x => x != _ofTypeStub).ToArray();

    private static readonly IEnumerable<Type>? _suppliedTypes = null;

    private static readonly Type[] _typeParameters = new Type[] { typeof(T1), typeof(T2), typeof(T3),
        typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) };

    private static readonly Type _ofTypeStub = typeof(Stubs.Basic);

    // should supply through context/properties but can't because of NUnit issues:
    // e.g. - github.com/nunit/nunit/issues/548
    private const string HardCodedMethodName = "CompileTestSource";
}


