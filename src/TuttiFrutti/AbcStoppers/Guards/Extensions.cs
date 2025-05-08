using AbcStoppers.Errors.Data;
using AbcStoppers.Errors.Sys;
using System.Collections;

namespace AbcStoppers.Guards;
public static class GuardExtensions
{
    public static T NoNull<T>(this T? value, string message = "")
        => value is null ? NullReference.Throw(message) : value;

    public static string NoEmpty(this string value, string message = "") =>
        value is "" ? Empty.Throw(message) : value;
    public static string NoEmpty(this ICollection value, string message = "") =>
       value.Count is 0 ? Empty.Throw(message) : value;
}
