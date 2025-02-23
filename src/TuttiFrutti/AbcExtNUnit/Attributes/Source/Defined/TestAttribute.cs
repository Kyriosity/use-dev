using AbcStuff.Test;
namespace AbcExtNUnit.Attributes.Source.Defined;

public class TestAttribute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params object[] args)
    : TestCaseSourceAttribute(typeof(CasesOutsource), nameof(CasesOutsource.PullYield), [SuppliedTypes, args])
    where T1 : IDataSource where T2 : IDataSource where T3 : IDataSource where T4 : IDataSource where T5 : IDataSource where T6 : IDataSource
    where T7 : IDataSource where T8 : IDataSource where T9 : IDataSource where T10 : IDataSource where T11 : IDataSource
{
    static IEnumerable<Type> SuppliedTypes => _suppliedTypes ??
    [.. _typeParameters.TakeWhile(x => x != _ofTypeStub)];

    private static readonly IEnumerable<Type>? _suppliedTypes = null;

    private static readonly Type[] _typeParameters = [ typeof(T1), typeof(T2), typeof(T3),
        typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) ];

    private static readonly Type _ofTypeStub = typeof(NotDataSource);
}
