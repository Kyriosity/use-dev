using Abc.Ext.setup;
using System.Runtime.CompilerServices;

namespace Abc.Ext.Errors.Sys;
public static class Argument<T>
{
    public static dynamic Throw() => throw new ArgumentException();
    public static dynamic Throw(string? message) => throw new ArgumentException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new ArgumentException(message, inner);
}

public static class Argument
{
    public static dynamic ThrowAll(string? message, object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
        object? arg6 = null, object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,
        [CallerArgumentExpression(nameof(arg1))] string proto1 = $"{Arg.Required}1",
        [CallerArgumentExpression(nameof(arg2))] string proto2 = $"{Arg.Required}2",
        [CallerArgumentExpression(nameof(arg3))] string proto3 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg4))] string proto4 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg5))] string proto5 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg6))] string proto6 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg7))] string proto7 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg8))] string proto8 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg9))] string proto9 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg10))] string proto10 = Arg.NotSubmitted,
        [CallerArgumentExpression(nameof(arg11))] string proto11 = Arg.NotSubmitted,
        [CallerMemberName] string caller = Caller.NotSpecified) {

        var digest = new[] { proto1, proto2, proto3, proto4, proto5, proto6, proto7, proto8, proto9, proto10, proto11 };

        throw new ArgumentException($"`{string.Join("`, `", digest.Where(x => x != Arg.NotSubmitted))}`");
    }
}
