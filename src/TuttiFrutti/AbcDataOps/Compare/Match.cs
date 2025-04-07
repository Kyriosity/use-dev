using AbcDataOps.Text.Alter;

namespace AbcDataOps.Compare;
public class Match
{
    public static Type? ObjectType(object subject, IEnumerable<string> matches) =>
        ObjectType<object>(subject, matches);

    public static Type? ClassHierarchy(Type? type, IList<string> matches) =>
        ClassHierarchy<object>(type, matches);

    public static Type? ObjectType<T>(object subject, IEnumerable<string> matches) =>
        ClassHierarchy<T>(subject.GetType(), matches.ToList());

    public static Type? ClassHierarchy<T>(Type? type, IList<string> matches) {
        var typeOfT = typeof(T);

        while (typeOfT.IsAssignableFrom(type)) {
            if (matches.Any(sample => type.
                    FullName != null && type.FullName.Right() == sample))
                return type;

            type = type.BaseType;
        }

        return null;
    }
}