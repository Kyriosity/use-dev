using AbcExt.Errors.Shortcuts;
using AbcExt.Stubs.Args;

namespace AbcExt.Errors.Sys;
public class Argument : MultiparameterConditional<ArgumentException>
{
    private Argument() { /* to prevent direct instantiation */ }

    public static bool ThrowIfAny<T>(Predicate<T> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        YOU_REACHED_ARGs_LIMIT___METAs_NEXT _ = default,

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "",
        [ArgExpr(nameof(predicate))] string condition = "<predicate>") {

        var args = new[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return OnCondition<T>(predicate, (i, _) => 0 < i, args, condition);
    }

    public static bool ThrowIfTogether<T>(Predicate<IEnumerable<T>> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        [ArgExpr(nameof(predicate))] string condition = "<predicate>",

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "") {

        var args = new[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return OnCondition<T>(predicate, args, condition);
    }

    [Obsolete("This criteria (each) seeks to lack the sense for guarding")]
    public static bool ThrowIfEach<T>(Predicate<T> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        [ArgExpr(nameof(predicate))] string condition = "<predicate>",

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "") {

        var args = new[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return OnCondition<T>(predicate, (i, j) => i == j, args, condition);
    }
}
