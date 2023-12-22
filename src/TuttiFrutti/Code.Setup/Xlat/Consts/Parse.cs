using System.Diagnostics.CodeAnalysis;

namespace Abc.Ext.Xlat.Consts;
public static class Parse
{
    private const bool _ignoreCase = true;

    public static bool Try<TOut>(string raw, [NotNullWhen(true)] out TOut? match) where TOut : Enum {
        var success = Enum.TryParse(typeof(TOut), raw, _ignoreCase, out object? parsed);
        match = success ? (TOut?)parsed : default;
        return success;
    }

    public static bool Try<TFrom, TOut>(TFrom raw, [NotNullWhen(true)] out TOut? match) where TFrom : Enum where TOut : Enum
        => Try<TOut>(raw.ToString(), out match);
}
