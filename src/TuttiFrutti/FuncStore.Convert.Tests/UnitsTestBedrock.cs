using System.Numerics;

namespace FuncStore.Convert.Tests;
public abstract class UnitsTestBedrock<TStore, TUnit> where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    protected IFuncStore<TUnit> _funcs = new FuncStoreStub<TUnit>();

    [OneTimeSetUp]
    public void FixtureSetup() { _funcs = new TStore(); }

    protected IDictionary<string, TUnit> Parse(out IEnumerable<string> unparsed, params string[] raw) {
        var parsed = raw.Distinct(StringComparer.InvariantCultureIgnoreCase).Select(
            x => (key: x, succcess: Meas.Units.Metric.TryLooseMatch<TUnit>(x, out var unit), unit))
            .ToList();

        unparsed = parsed.Where(x => !x.succcess).Select(x => x.key);

        var res = parsed.ToDictionary(x => x.key, x => x.unit, StringComparer.InvariantCultureIgnoreCase);
        return res;
    }

    protected bool CheckConvert<N>((TUnit? unit, N val) from, (TUnit? unit, N val) to, out N result) where N : INumber<N> {
        if (from.unit is null || to.unit is null)
            throw new ArgumentException($""); // ToDo: Guard.Null()

        var func = _funcs.For<N>(from.unit, to.unit);
        Assert.That(func, Is.Not.Null, $"{_funcs}<{typeof(TUnit).Name}>({from}->{to}) n/a");
        result = func(from.val);
        Assert.That(result, Is.EqualTo(to.val));

        return true;
    }


}
