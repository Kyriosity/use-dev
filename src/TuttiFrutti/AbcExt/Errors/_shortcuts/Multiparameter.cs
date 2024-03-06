using AbcExt.Wording;

namespace AbcExt.Errors.Shortcuts;
public abstract class Multiparameter<TExc>(string? message = "", Exception? inner = null)
    : Regular<TExc>(message, inner) where TExc : Exception
{
    public static dynamic Throw(string? message,
        object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null, object? arg6 = null,
        object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,

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

        var submitted = new[]
                { proto1, proto2, proto3, proto4, proto5, proto6, proto7, proto8, proto9, proto10, proto11 }
            .Where(x => x != Arg.NotSubmitted);

        return Throw($"{message}: \"{string.Join("`, `", submitted)}\"");
    }
}
