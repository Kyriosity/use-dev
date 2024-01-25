using System.Reflection;

namespace Abc.Ext.Metadata;
public class UtilizedAttribute<TSelf> : Attribute where TSelf : UtilizedAttribute<TSelf>
{
    public static bool From<T>(MemberInfo member, out T found) {
        var attribute = From(member).SingleOrDefault();

        if (attribute is not null) {
            var prop = attribute.GetType().GetProperties()
                .SingleOrDefault(x => x.PropertyType == typeof(T));
            if (prop is not null) {
                found = (T)prop.GetValue(attribute);
                return true;
            }
        }
        found = default;
        return false;
    }

    public static IEnumerable<TSelf> From(MemberInfo member) =>
        member.GetCustomAttributes(typeof(TSelf), true).Select(x => (TSelf)x);
}
