using System.Runtime.CompilerServices;

namespace Abc.Err.Sys;

/// <summary>
/// Enhances ArgumentNullException helpers for multiple arguments. 
/// Be kind, mark [Obsolete] if similar methods come with a new .NET release.
/// </summary>
public static class ArgumentNull
{
    private const string _required_arg = "!<req/arg>!";
    private const string _not_submitted = "?<no/proto>?";
    private const string _unspecified_caller = "?<no/caller>?";
    public static void ThrowIfAny(object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
        object? arg6 = null, object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,
        [CallerArgumentExpression(nameof(arg1))] string proto1 = $"{_required_arg}1",
        [CallerArgumentExpression(nameof(arg2))] string proto2 = $"{_required_arg}2",
        [CallerArgumentExpression(nameof(arg3))] string proto3 = _not_submitted,
        [CallerArgumentExpression(nameof(arg4))] string proto4 = _not_submitted,
        [CallerArgumentExpression(nameof(arg5))] string proto5 = _not_submitted,
        [CallerArgumentExpression(nameof(arg6))] string proto6 = _not_submitted,
        [CallerArgumentExpression(nameof(arg7))] string proto7 = _not_submitted,
        [CallerArgumentExpression(nameof(arg8))] string proto8 = _not_submitted,
        [CallerArgumentExpression(nameof(arg9))] string proto9 = _not_submitted,
        [CallerArgumentExpression(nameof(arg10))] string proto10 = _not_submitted,
        [CallerArgumentExpression(nameof(arg11))] string proto11 = _not_submitted,
        [CallerMemberName] string caller = _unspecified_caller
        ) {
        var digest = new (object? arg, string proto)[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4),
            (arg5, proto5), (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };

        var castOut = digest.Where(x => x.arg == null && x.proto != _not_submitted).ToList();

        if (castOut.Any())
            ArgumentNull.Throw($"{caller}() supplied null as: '{string.Join("', ", castOut.Select(x => x.proto).Distinct())}'");
    }

    public static void ThrowIfAll(object arg1, object arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
    object? arg6 = null, object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,
    [CallerArgumentExpression(nameof(arg1))] string proto1 = $"{_required_arg}1",
    [CallerArgumentExpression(nameof(arg2))] string proto2 = $"{_required_arg}2",
    [CallerArgumentExpression(nameof(arg3))] string proto3 = _not_submitted,
    [CallerArgumentExpression(nameof(arg4))] string proto4 = _not_submitted,
    [CallerArgumentExpression(nameof(arg5))] string proto5 = _not_submitted,
    [CallerArgumentExpression(nameof(arg6))] string proto6 = _not_submitted,
    [CallerArgumentExpression(nameof(arg7))] string proto7 = _not_submitted,
    [CallerArgumentExpression(nameof(arg8))] string proto8 = _not_submitted,
    [CallerArgumentExpression(nameof(arg9))] string proto9 = _not_submitted,
    [CallerArgumentExpression(nameof(arg10))] string proto10 = _not_submitted,
    [CallerArgumentExpression(nameof(arg11))] string proto11 = _not_submitted,
    [CallerMemberName] string caller = _unspecified_caller) {
        var digest = new (object? arg, string proto)[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4),
            (arg5, proto5), (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };

        var submitted = digest.Where(x => x.proto != _not_submitted).ToList();

        if (submitted.All(x => x.arg is null))
            ArgumentNull.Throw($"{caller}() supplied all nulled ('{string.Join("', ", submitted.Select(x => x.proto)).Distinct()}')");
    }
    public static dynamic Throw() => throw new ArgumentNullException();
    public static dynamic Throw(string? message) => throw new ArgumentNullException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new ArgumentException(message, inner);
}
