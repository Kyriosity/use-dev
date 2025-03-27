using System.Linq.Expressions;
using System.Reflection;

namespace AbcExtNUnit.Asserted;
public class Exceptions : Variable
{
    // ToDesign: allowing multiple type of exception

    public Expression<Func<object, bool>> Throw {
        get => CANT_VALUE;
        set {
            var inspect = value.GetDebugView();
            var method = value.Compile();
            var res = method(value.Parameters);

            // ToDo: CALLER NAME AVAILABLE !
        }
    }
    // ThrowAll
    // ThrowAny
    // NoThrow
}

public static class Ext
{
    public static string GetDebugView(this Expression exp) {
        if (exp == null)
            return null;

        var propertyInfo = typeof(Expression).GetProperty("DebugView", BindingFlags.Instance | BindingFlags.NonPublic);
        return propertyInfo.GetValue(exp) as string;
    }
}
