namespace AbcRefl.Stack;

/// <summary>
/// This is a draft of call stack reporting to be reworked when applied wider
/// </summary>
public partial class Caller
{
    public static StackDetails Details(byte skipFrames = 1) {

        var method = new StackFrame(1 + skipFrames).GetMethod();
        var filename = new StackFrame(1 + skipFrames).GetFileName;

        var callerName = method?.Name;
        var container = method?.DeclaringType;
        var typeDecl = method?.DeclaringType;

        var methodInfo = method as MethodInfo;
        var memberType = methodInfo?.MemberType;
        var retType = methodInfo?.ReturnType;

        var isProp = false;
        const string propPrefix = "get_";
        if (container is not null && callerName is not null)
            if (callerName.StartsWith(propPrefix) && callerName.Length > propPrefix.Length) {
                var propName = callerName[propPrefix.Length..];
                var prop = container.GetProperty(propName,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

                callerName = propName;
                isProp = true;
            }

        if (!isProp)
            callerName += "()";

        return (
            (callerName, isProp ? MemberTypes.Property : method?.MemberType),
            (retType?.Name, retType?.FullName),
            (container?.Name, container?.FullName));
    }
}