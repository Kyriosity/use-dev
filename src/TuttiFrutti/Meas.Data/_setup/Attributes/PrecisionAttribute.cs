using System.Reflection;

namespace Meas.Data.Setup.Attributes;

[AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Field | System.AttributeTargets.Method, AllowMultiple = false)]
public class PrecisionAttribute(double delta) : Attribute
{
    public double Delta => delta;

    public static double? Find(Type type) => Find(type.GetCustomAttributes(true));

    public static double? Find(FieldInfo field) => Find(field.GetCustomAttributes(true));

    private static double? Find(object[] attributes) {
        var attribute = attributes.SingleOrDefault(attr => attr.GetType().Name == nameof(PrecisionAttribute));

        return attribute is PrecisionAttribute precision ? precision.Delta : null;
    }
}
