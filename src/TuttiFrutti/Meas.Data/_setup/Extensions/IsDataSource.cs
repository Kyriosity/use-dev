using Meas.Data.Setup.Attributes;
using Meas.Data.Setup.Formats;
using System.Reflection;

namespace Meas.Data.Setup.Extensions;
public interface IsDataSource { }

public static class DataExtensions
{
    public static IEnumerable<ISubject<double, string>> Itemize(this IsDataSource catalog) {
        var fields = catalog.GetType().GetFields();
        var chapters = fields.Select(f => (name: f.Name, dir: f.GetValue(null) as Dir, options: ApplyAttributes(f)));

        return chapters.Where(x => x.dir is not null)
            .SelectMany(x => List(x.name, x.dir, x.options));
    }

    private static IEnumerable<ISubject<double, string>> List(string chapterName, Dir dir, IDictionary<string, object> options) {

        var items = dir.Select(item => new ISubject<double, string> { Cat = chapterName, Name = item.Key, Entries = item.Value, Attributes = options });

        var skipped = items.Where(x => x.Attributes.Any(attr => attr.Key == "skip"));

        // ToDesign: SKIP (and other attributes) is experimental feature and must be reconsidered in next releases
        return items.Where(x => !x.Attributes.Any(attr => attr.Key == "skip"));
    }

    private static IDictionary<string, object> ApplyAttributes(FieldInfo field) {
        var options = new Dictionary<string, object>();
        var attributes = field.GetCustomAttributes(true);

        var attr = attributes.SingleOrDefault(attr => attr.GetType().Name == nameof(NotForTestAttribute));
        if (attr is not null)
            options["skip"] = ((NotForTestAttribute)attr).Reason;

        var delta = PrecisionAttribute.Find(field);
        if (delta is not null)
            options[nameof(PrecisionAttribute)] = delta;
        return options;
    }
}
