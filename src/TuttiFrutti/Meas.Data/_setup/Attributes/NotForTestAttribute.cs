using System.Reflection;

namespace Meas.Data.Setup.Attributes;
[AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false)]
public class NotForTestAttribute(string reason = "") : Attribute
{
    public string Reason { get; init; } = reason;

    public static bool Find(Type type, out string reason) => Find(type.GetCustomAttributes(true), out reason);

    public static bool Find(FieldInfo field, out string reason) => Find(field.GetCustomAttributes(true), out reason);

    private static bool Find(object[] attributes, out string reason) {
        var targetName = MethodBase.GetCurrentMethod()?.DeclaringType?.Name ?? "<attr_name fail/>";

        var attribute = attributes.SingleOrDefault(attr => attr.GetType().Name == targetName);

        if (attribute is NotForTestAttribute found) {
            // KD: casting to reflected declaring type is possible but too elaborated
            reason = found.Reason;
            return true;
        }
        reason = string.Empty; return false;
    }
}
