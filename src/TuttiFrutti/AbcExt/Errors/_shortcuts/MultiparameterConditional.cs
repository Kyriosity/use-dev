using AbcExt.Wording;
using System.Runtime.CompilerServices;

namespace AbcExt.Errors.Shortcuts;
public abstract class MultiparameterConditional<TExc>(string? message = "", Exception? inner = null)
    : Multiparameter<TExc>(message, inner) where TExc : Exception
{
    protected virtual dynamic? OnCondition(Predicate<object> predicate, uint greaterThanCount, string message,
        object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null, object? arg6 = null,
        object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,

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

        var submitted = new (object? arg, string proto)[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4),
            (arg5, proto5), (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) }
            .Where(x => x.proto != Arg.NotSubmitted).ToList();

        var castOut = submitted.Where(x => predicate(x)).ToList();

        if (castOut.Count is 0)
            return false;

        var digest = string.Join("', ", castOut.Select(x => x.proto).Distinct());

        //if (threshold is < 0 || threshold <= castOut.Count)
        //    Throw($"{message}: {digest}");

        return false;
    }
}
