using System.Diagnostics;
using System.Reflection;

namespace AbcExt.Refl;
public class Caller
{
    public static
        ((string? name, MemberTypes? member) caller,
        (string? name, string? fullName) type,
        (string? name, string? fullName) container)


        Report(byte skipFrames = 1) {


        var caller = new StackFrame(1 + skipFrames)?.GetMethod();
        var callerName = caller?.Name;
        var container = caller?.DeclaringType;

        var methodInfo = caller as MethodInfo;
        var memberType = methodInfo?.MemberType;
        var retType = methodInfo?.ReturnType;

        var isProp = false;
        const string propPrefix = "get_";
        if (container is not null && callerName is not null)
            if (callerName.StartsWith(propPrefix) && callerName.Length > propPrefix.Length) {
                var propName = callerName.Substring(propPrefix.Length);
                var prop = container.GetProperty(propName,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

                if (callerName is not null) {
                    callerName = propName;
                    isProp = true;
                }
            }
        if (!isProp)
            callerName += "()";

        return ((callerName, isProp ? MemberTypes.Property : caller?.MemberType), (retType?.Name, retType?.FullName), (container?.Name, container?.FullName));
    }
}
