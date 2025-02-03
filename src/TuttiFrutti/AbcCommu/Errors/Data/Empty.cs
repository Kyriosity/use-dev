namespace AbcCommu.Errors.Data;

public class Empty(string message) : Exception<NotSet>(message)
{
    public static bool ThrowIf<T>(IEnumerable<T> coll, [ArgExpr(nameof(coll))] string expr = "") =>
        coll.Any() ? false : throw new Empty(expr);

    public static bool ThrowIf(string value, [ArgExpr(nameof(value))] string expr = "")
        => string.Empty == value ? false : throw new Empty(expr);

    public static bool ThrowIfWhitespace(string value, [ArgExpr(nameof(value))] string expr = "") =>
        string.IsNullOrWhiteSpace(value) ? throw new Empty(expr) : false;
}