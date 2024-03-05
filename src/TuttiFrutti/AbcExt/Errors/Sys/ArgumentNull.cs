using AbcExt.Errors.Shortcuts;
using AbcExt.Wording;
using System.Runtime.CompilerServices;

namespace AbcExt.Errors.Sys;

public class ArgumentNull : MultiparameterConditional<ArgumentNullException>
{
    private ArgumentNull() { /* to prevent direct instantiation */ }

    public static void ThrowIfAny(object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
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
        [CallerArgumentExpression(nameof(arg11))] string proto11 = Arg.NotSubmitted
        ) {

        var args = new[]  { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4), (arg5, proto5),
            (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };
        OnCondition(x => x is null, (i, _) => 0 < i, args);
    }

    public static void ThrowIfAll(object arg1, object arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
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
    [CallerArgumentExpression(nameof(arg11))] string proto11 = Arg.NotSubmitted) {

        var args = new[]  { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4), (arg5, proto5),
            (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };
        OnCondition(x => x is null, (i, j) => i == j, args);
    }
}
