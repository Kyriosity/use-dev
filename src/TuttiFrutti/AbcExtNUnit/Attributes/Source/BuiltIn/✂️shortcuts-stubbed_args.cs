namespace AbcExtNUnit.Attributes.Source.BuiltIn;

public class TestAttribute<T>(params string[] args) : TestAttribute<T, NotSupplied>(args);
public class TestAttribute<T1, T2>(params string[] args) : TestAttribute<T1, T2, NotSupplied>(args);
public class TestAttribute<T1, T2, T3>(params string[] args) : TestAttribute<T1, T2, T3, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4>(params string[] args) : TestAttribute<T1, T2, T3, T4, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5>(params string[] args) : TestAttribute<T1, T2, T3, T4, T5, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5, T6>(params string[] args) : TestAttribute<T1, T2, T3, T4, T5, T6, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, NotSupplied>(args);
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, NotSupplied>(args);
