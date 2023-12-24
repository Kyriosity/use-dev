namespace Abc.Ext.NUnit.Metadata.Source;
public class TestOfAttribute<T>(params string[] args) : TestOfAttribute<T, Stub>(args) { }
public class TestOfAttribute<T1, T2>(params string[] args) : TestOfAttribute<T1, T2, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3>(params string[] args) : TestOfAttribute<T1, T2, T3, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, Stub>(args) { }
public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params string[] args) : TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Stub>(args) { }

public class TestOfAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params string[] args)
    : TestCaseSourceAttribute(GetMakeDataName(), new object[] { OfTypes, args })
{
    private static IEnumerable<Type> OfTypes => _ofTypes ?? TypeParameters.TakeWhile(x => x != ofTypeStub).ToArray();
    private static IEnumerable<Type>? _ofTypes;

    private static Type[] TypeParameters = new Type[] { typeof(T1), typeof(T2), typeof(T3),
        typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) };

    private static readonly Type ofTypeStub = typeof(Stub);

    private static string GetMakeDataName() {
        // should supply through context/properties but can't because of NUnit issues:
        // e.g. github.com/nunit/nunit/issues/548
        return "MakeTestSource";
    }
}

public class Stub { }
