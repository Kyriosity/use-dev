using AbcExt.Errors.Sys;
using AbcExt.Stubs.Args;
using System.Text.RegularExpressions;

namespace AbcExt.Errors.Argument;
public partial class DuplicatedArguments(string message) : Shortcut<DuplicatedArguments>(message)
{
    public static Func<string?, string?, bool> LooseEqual =>
        (a, b) => 0 == string.Compare(Normalize(a), Normalize(b), StringComparison.InvariantCultureIgnoreCase);

    public static bool ThrowIfAny<T>(T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        YOU_REACHED_ARGs_LIMIT___METAs_NEXT _ = default,

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "") {

        var args = new (T val, string tag)[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        Func<T, T, bool> exactEqual = (a, b) => (a is null && b is null) || (a is not null && b is not null && a.Equals(b));
        return ThrowIfAny(exactEqual, args);
    }

    public static bool ThrowIfAny<T>(Func<T, T, bool> match, T arg1, T arg2, T arg3 = default, T arg4 = default, T arg5 = default,
        T arg6 = default, T arg7 = default, T arg8 = default, T arg9 = default, T arg10 = default, T arg11 = default,

        YOU_REACHED_ARGs_LIMIT___METAs_NEXT _ = default,

        [ArgExpr(nameof(arg1))] string exp1 = "", [ArgExpr(nameof(arg2))] string exp2 = "", [ArgExpr(nameof(arg3))] string exp3 = "",
        [ArgExpr(nameof(arg4))] string exp4 = "", [ArgExpr(nameof(arg5))] string exp5 = "", [ArgExpr(nameof(arg6))] string exp6 = "",
        [ArgExpr(nameof(arg7))] string exp7 = "", [ArgExpr(nameof(arg8))] string exp8 = "", [ArgExpr(nameof(arg9))] string exp9 = "",
        [ArgExpr(nameof(arg10))] string exp10 = "", [ArgExpr(nameof(arg11))] string exp11 = "", [ArgExpr(nameof(match))] string matchInfo = ""
) {

        var args = new (T val, string tag)[] { (arg1, exp1), (arg2, exp2), (arg3, exp3), (arg4, exp4), (arg5, exp5),
            (arg6, exp6), (arg7, exp7), (arg8, exp8), (arg9, exp9), (arg10, exp10), (arg11, exp11) };

        return ThrowIfAny(match, args, matchInfo);
    }

    protected static bool ThrowIfAny<T>(Func<T, T, bool> condition, (T val, string tag)[] args,
        [ArgExpr(nameof(condition))] string conditionInfo = "") {
        ArgumentNull.ThrowIfAny(condition, args);

        var submmitted = args.Where(x => !string.IsNullOrEmpty(x.tag));

        var overlap = new List<List<(T val, string tag)>>();
        do {
            var split = SplitByMatch((a, b) => condition(a.val, b.val), submmitted, out submmitted).ToList();
            if (1 < split.Count)
                overlap.Add(split);
        } while (0 < submmitted.Count());


        if (overlap.Any())
            Throw($"{conditionInfo}:  \n{ReportDuplicatesOverlap(overlap)}");

        return false;
    }

    private static IEnumerable<T> SplitByMatch<T>(Func<T, T, bool> condition, IEnumerable<T> source, out IEnumerable<T> remainder) {
        ArgumentNull.ThrowIfAny(condition, source);

        var list = source.ToList(); var total = list.Count;
        remainder = [];

        if (total is 0)
            return [];

        var pattern = list.First();
        var matches = list.Where(x => condition(x, pattern)).ToList();

        if (matches.Count < total)
            remainder = list.Where(x => !condition(x, pattern));

        return matches;
    }

    private static string ReportDuplicatesOverlap<T>(IEnumerable<List<(T val, string tag)>> overlaps) {

        var xlated = overlaps.Select(row => string.Join("; ", row.Select(x => $"{x.tag}->{x.val}")));

        return string.Join("\n", xlated);
    }

    private static string Normalize(string? raw) => string.IsNullOrWhiteSpace(raw) ? string.Empty :
        LooseSeparation().Replace(raw.Trim(), " ");

    [GeneratedRegex(@"\s+")]
    private static partial Regex LooseSeparation();
}
