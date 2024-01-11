using Meas.Data.Setup.Formats;
using RawData = (string name, object value, (bool set, double? delta) precision);

namespace Meas.Data.Setup.Extensions;
public static class TestSource
{
    public static object[][] FromRecords(IEnumerable<RawData> fields) {
        var casted = fields.Select(x => (success: ToDataRows(x, out var result), row: result));
        return casted.Where(x => x.success).SelectMany(x => x.row).ToArray();
    }

    private static bool ToDataRows(RawData source, out object[][] rows) {
        rows = null;
        if (source.value is Rec rec) {
            rows = rec.Select(x => new object[] {
                x.leftVal, x.leftUnit, x.rightVal, x.rightUnit, x.note, source.name, source.precision.delta})
                .ToArray();
            return true;
        }

        return rows is not null;
    }

    public static IEnumerable<MeasSubject> FromMeasurements(IEnumerable<RawData> fields) {
        var casted = fields.Select(x => (success: ToDataItems(x, out var result), items: result));
        return casted.Where(x => x.success).SelectMany(x => x.items);
    }

    private static bool ToDataItems(RawData source, out IEnumerable<MeasSubject> items) {
        items = null;
        if (source.value is Dir dir) {
            items = dir.Select(x => new MeasSubject {
                Cat = source.name, Name = x.Key, Entries = x.Value,
                Delta = source.precision.delta
            });
        }

        return items is not null;
    }
}

