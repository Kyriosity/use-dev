﻿using MeasData.Setup.Formats;
using MeasUnits.Utils;

namespace FuncStore.Convers.Tests.Setup.Proc;
static class Units<TUnit> where TUnit : Enum
{
    internal static IEnumerable<Subject<N, TUnit>> SwapParseable<N>(IEnumerable<Subject<N, string>> items) where N : INumber<N> {
        var unitized = items.Select(x => new Subject<N, TUnit> {
            Cat = x.Cat, Name = x.Name, Delta = x.Delta, Entries = SwapParseable(x.Entries)
        }).ToList();

        return unitized;
    }

    internal static object[][] SwapParseable(ObjArrays source, int[] indexes) {
        var unitCasted = source.Select(x => (success: TryCast(x, indexes, out var cast), result: cast.ToArray()))
            .Where(x => x.success).Select(x => x.result);
        return unitCasted.ToArray();
    }

    internal static bool TryCast(object[] raw, int[] indexes, out IEnumerable<object> casted) {
        var units = indexes.Select(i =>
                (success: Match.TryLoose(raw[i] as string ?? Argument.Throw("Can't cast to string"), out TUnit? unit), result: unit, index: i))
            .ToArray();

        casted = raw.Select((x, index) =>
            indexes.Contains(index) ? units.Single(u => u.index == index).result : x);

        return units.All(x => x.success);
    }

    private static IEnumerable<(N, TUnit)> SwapParseable<N>(IEnumerable<(N value, string unit)> source) where N : INumber<N> {
        var casted = source.Select(x => (value: x.value, success: Match.TryLoose(x.unit, out TUnit? match), unit: match));
        var unitized = casted.Where(x => x.success).Select(x => (x.value, x.unit));

        return unitized;
    }
}
