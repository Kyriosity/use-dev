using System.Diagnostics.CodeAnalysis;

namespace Abc.Ext.Xlat;
public static class Parse
{
    private const bool _ignoreCase = true;

    public static bool Try<T>(string rawMember, [NotNullWhen(true)] out T? match) where T : Enum {
        var success = Enum.TryParse(typeof(T), rawMember, _ignoreCase, out object? parsed);
        match = success ? (T?)parsed : default;
        return success;
    }
}
