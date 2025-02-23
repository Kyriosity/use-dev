using AbcStuff.Test;

namespace AbcExtNUnit.Attributes.Source.Defined;

public class TestAttribute<T>(params string[] args) : TestAttribute<T, NotDataSource>(args)
    where T : IDataSource;

public class TestAttribute<T1, T2>(params string[] args) : TestAttribute<T1, T2, NotDataSource>(args)
   where T1 : IDataSource where T2 : IDataSource;
public class TestAttribute<T1, T2, T3>(params string[] args) : TestAttribute<T1, T2, T3, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource;
public class TestAttribute<T1, T2, T3, T4>(params string[] args) : TestAttribute<T1, T2, T3, T4, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5>(params string[] args) : TestAttribute<T1, T2, T3, T4, T5, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5, T6>(params string[] args) : TestAttribute<T1, T2, T3, T4, T5, T6, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource
    where T7 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource
    where T7 : IDataSource where T8 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource
    where T7 : IDataSource where T8 : IDataSource where T9 : IDataSource;
public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params string[] args) :
    TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, NotDataSource>(args)
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource
    where T7 : IDataSource where T8 : IDataSource where T9 : IDataSource where T10 : IDataSource;