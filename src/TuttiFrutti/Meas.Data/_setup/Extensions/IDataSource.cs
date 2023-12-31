﻿using Meas.Data.Formats;
using Meas.Data.Setup.Attributes;
using System.Reflection;

namespace Meas.Data.Setup.Extensions;
public interface IDataSource { }

public static class DataExtensions
{
    public static IEnumerable<ISubject<double, string>> Itemize(this IDataSource catalog) {
        var fields = catalog.GetType().GetFields();
        var chapters = fields.Select(f => (name: f.Name, dir: f.GetValue(null) as Dir, options: ApplyAttributes(f)));

        return chapters.Where(x => x.dir is not null)
            .SelectMany(x => List(x.name, x.dir, x.options));
    }

    private static IEnumerable<ISubject<double, string>> List(string chapterName, Dir dir, IDictionary<string, string> options) {

        var items = dir.Select(item => new ISubject<double, string> { Cat = chapterName, Name = item.Key, Entries = item.Value, Attributes = options });

        var skipped = items.Where(x => x.Attributes.Any(attr => attr.Key == "skip"));

        // ToDesign: SKIP (and other attributes) is experimental feature and must be reconsidered in next releases
        return items.Where(x => !x.Attributes.Any(attr => attr.Key == "skip"));
    }

    private static IDictionary<string, string> ApplyAttributes(FieldInfo field) {
        var options = new Dictionary<string, string>();
        var attributes = field.GetCustomAttributes(true);

        var attr = attributes.SingleOrDefault(attr => attr.GetType().Name == nameof(NotForTestAttribute));
        if (attr is not null)
            options["skip"] = ((NotForTestAttribute)attr).Reason;
        return options;
    }
}
