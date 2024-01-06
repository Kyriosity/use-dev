using System.Reflection;

namespace Meas.Data.Setup.Attributes;

[AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Field | System.AttributeTargets.Method, AllowMultiple = false)]
public class PrecisionAttribute(double delta) : Attribute
{
    public double Delta => delta;

    public static bool Find(Type type, out double delta) => Find(type.GetCustomAttributes(true), out delta);

    public static bool Find(FieldInfo field, out double delta) => Find(field.GetCustomAttributes(true), out delta);

    private static bool Find(object[] attributes, out double delta) {
        var targetName = MethodBase.GetCurrentMethod()?.DeclaringType?.Name ?? "<attr_name fail/>";

        var attribute = attributes.SingleOrDefault(attr => attr.GetType().Name == targetName);

        if (attribute is PrecisionAttribute found) {
            delta = found.Delta;
            return true;
        }
        delta = default; return false;
    }
}
