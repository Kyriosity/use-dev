using AbcExt.Errors.Shortcuts;
using AbcExt.Wording;

namespace AbcExt.Errors.Sys;
public class Argument : MultiparameterConditional<ArgumentException>
{
    private Argument() { /* to prevent direct instantiation */ }

    public static bool ThrowIfAny<T>(Predicate<T> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        [ArgExpr(nameof(predicate))] string condition = "<predicate>",

        [ArgExpr(nameof(arg1))] string proto1 = "", [ArgExpr(nameof(arg2))] string proto2 = "",
        [ArgExpr(nameof(arg3))] string proto3 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg4))] string proto4 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg5))] string proto5 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg6))] string proto6 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg7))] string proto7 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg8))] string proto8 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg9))] string proto9 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg10))] string proto10 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg11))] string proto11 = Arg.NotSubmitted
        ) {

        var args = new[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4), (arg5, proto5),
            (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };

        return OnCondition<T>(predicate, (i, _) => 0 < i, args, condition);
    }


    public static bool ThrowIfTogether<T>(Predicate<IEnumerable<T>> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        [ArgExpr(nameof(predicate))] string condition = "<predicate>",

        [ArgExpr(nameof(arg1))] string proto1 = $"{Arg.Required}1",
        [ArgExpr(nameof(arg2))] string proto2 = $"{Arg.Required}2",
        [ArgExpr(nameof(arg3))] string proto3 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg4))] string proto4 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg5))] string proto5 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg6))] string proto6 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg7))] string proto7 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg8))] string proto8 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg9))] string proto9 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg10))] string proto10 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg11))] string proto11 = Arg.NotSubmitted
    ) {
        var args = new[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4), (arg5, proto5),
            (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };

        return OnCondition<T>(predicate, args, condition);
    }

    [Obsolete("This selection may lack sense for guarding")]
    public static bool ThrowIfEach<T>(Predicate<T> predicate, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        [ArgExpr(nameof(predicate))] string condition = "<predicate>",

        [ArgExpr(nameof(arg1))] string proto1 = $"{Arg.Required}1",
        [ArgExpr(nameof(arg2))] string proto2 = $"{Arg.Required}2",
        [ArgExpr(nameof(arg3))] string proto3 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg4))] string proto4 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg5))] string proto5 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg6))] string proto6 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg7))] string proto7 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg8))] string proto8 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg9))] string proto9 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg10))] string proto10 = Arg.NotSubmitted,
        [ArgExpr(nameof(arg11))] string proto11 = Arg.NotSubmitted) {

        var args = new[] { (arg1, proto1), (arg2, proto2), (arg3, proto3), (arg4, proto4), (arg5, proto5),
            (arg6, proto6), (arg7, proto7), (arg8, proto8), (arg9, proto9), (arg10, proto10), (arg11, proto11) };

        return OnCondition<T>(predicate, (i, j) => i == j, args, condition);
    }
}
