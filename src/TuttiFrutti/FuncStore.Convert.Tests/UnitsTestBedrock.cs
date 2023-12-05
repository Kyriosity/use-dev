using System.Numerics;

namespace FuncStore.Convert.Tests;
public abstract class UnitsTestBedrock<TStore, TUnit> where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    protected IFuncStore<TUnit> _funcs = new FuncStoreStub<TUnit>();

    [OneTimeSetUp]
    public void FixtureSetup() { _funcs = new TStore(); }

    protected IDictionary<string, TUnit> Parse(out IEnumerable<string> unparsed, params string[] raw) {
        var parsed = raw.Distinct(StringComparer.InvariantCultureIgnoreCase).Select(key
            => (key, succcess: Meas.Units.Metric.TryLooseMatch<TUnit>(key, out var unit), unit))
            .ToList();

        unparsed = parsed.Where(x => !x.succcess).Select(x => x.key);
#pragma warning disable CS8619 // `unit` can't be null on `success`==true
        return parsed.Where(x => x.succcess).ToDictionary(x => x.key, x => x.unit, StringComparer.InvariantCultureIgnoreCase);
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
    }

    protected bool CheckConvert<N>((TUnit? unit, N val) from, (TUnit? unit, N val) to, out N result) where N : INumber<N> {
        ArgumentNull.ThrowIfAny(from.unit, to.unit);

        var func = _funcs.For<N>(from.unit, to.unit);
        Assert.That(func, Is.Not.Null, $"{_funcs}<{typeof(TUnit).Name}>({from}->{to}) n/a");
        result = func(from.val);



        // EXACT MATCH
        // TOLERATED
        // FAIL
        Assert.That(result, Is.EqualTo(to.val));

        return true;
    }
}
