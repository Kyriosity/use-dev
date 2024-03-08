using AbcExt.Errors.Shortcuts;
using AbcExt.Stubs.Args;

namespace AbcExt.Errors.Sys;

public class ArgumentNull : MultiparameterConditional<ArgumentNullException>
{
    private ArgumentNull() { /* to prevent direct instantiation */ }

    public static bool ThrowIfAny(object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
        object? arg6 = null, object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,

        YOU_REACHED_ARGs_LIMIT___METAs_NEXT _ = default,

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = ""
        ) {

        var args = new[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return OnCondition(x => x is null, (i, _) => 0 < i, args);
    }

    public static bool ThrowIfEach(object arg1, object arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null,
    object? arg6 = null, object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,
    [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
    [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
    [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
    [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "") {

        var args = new[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return OnCondition(x => x is null, (i, j) => i == j, args);
    }
}
