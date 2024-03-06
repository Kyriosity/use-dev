namespace AbcExt.Errors.Shortcuts;
public abstract class Multiparameter<TExc>(string? message = "", Exception? inner = null)
    : Regular<TExc>(message, inner) where TExc : Exception
{
    public static dynamic Throw(string? message,
        object? arg1, object? arg2, object? arg3 = null, object? arg4 = null, object? arg5 = null, object? arg6 = null,
        object? arg7 = null, object? arg8 = null, object? arg9 = null, object? arg10 = null, object? arg11 = null,

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "") {

        var submitted = new[]
                { exp1, exp2, exp3, exp4, exp5, exp6, exp7, exp8, exp9, exp10, exp11 }
            .Where(x => !string.IsNullOrEmpty(x));

        return Throw($"{message}: \"{string.Join("`, `", submitted)}\"");
    }
}
