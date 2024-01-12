using System.Reflection;

namespace Meas.Units.Metadata;

[AttributeUsage(System.AttributeTargets.Enum, AllowMultiple = false)]
public class ExponentAttribute(int @base) : System.Attribute
{
    public int Base => @base;

    public static bool Find<U>(out int @base) where U : Enum {
        var targetName = MethodBase.GetCurrentMethod()?.DeclaringType?.Name ?? "<attr_name fail/>";

        var attribute = typeof(U).GetCustomAttributes(true).SingleOrDefault(attr => attr.GetType().Name == targetName);

        if (attribute is ExponentAttribute found) {
            @base = found.Base;
            return true;
        }
        @base = default; return false;
    }
}