using MeasData.Setup.Formats;
using RawData = (string name, object value, double? delta);

namespace MeasData.Setup.Extensions;
public static class TestSource
{
    public static object[][] FromRecords(IEnumerable<RawData> fields) {
        var casted = fields.Select(x => (success: ToDataRows(x, out var result), row: result));
        return casted.Where(x => x.success).SelectMany(x => x.row).ToArray();
    }

    private static bool ToDataRows(RawData source, out object[][] rows) {
        if (source.value is not Rec rec) {
            rows = null;
            return false;
        }

        rows = rec.Select(x => new object[] {
            x.leftVal, x.leftUnit, x.rightVal, x.rightUnit, x.note, source.name, source.delta })
            .ToArray();

        return true;
    }

    public static IEnumerable<MeasSubject> FromMeasurements(IEnumerable<RawData> fields) {
        var casted = fields.Select(x => (success: ToDataItems(x, out var result), items: result));
        return casted.Where(x => x.success).SelectMany(x => x.items);
    }

    private static bool ToDataItems(RawData source, out IEnumerable<MeasSubject> items) {
        if (source.value is not Dir dir) {
            items = null;
            return false;
        }

        items = dir.Select(x => new MeasSubject {
            Cat = source.name, Name = x.Key, Entries = x.Value,
            Delta = source.delta
        });
        return true;
    }
}

