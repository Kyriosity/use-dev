namespace AbcExt.Errors.Basal;
public abstract class MultiparameterConditional<Exc>(string? message = "", Exception? inner = null)
    : Multiparameter<Exc>(message, inner) where Exc : Exception
{
    protected static bool OnCondition<T>(Predicate<T> predicate, Func<int, int, bool> countTrigger,
        (T val, string tag)[] args, string predicateInfo = "") {
        var submitted = args.Where(x => !string.IsNullOrEmpty(x.tag)).ToList();
        var match = submitted.Select((x, i) => (idx: i, x.val, x.tag))
            .Where(x => predicate(x.val)).ToList();

        if (countTrigger(match.Count, submitted.Count))
            Throw($"{MessagePrefix(predicateInfo)}{Digest(match)}");

        return false;
    }

    protected static bool OnCondition<T>(Predicate<IEnumerable<T>> predicate, (T val, string tag)[] args, string predicateInfo = "") {
        var submitted = args.Where(x => !string.IsNullOrEmpty(x.tag)).ToList();

        if (predicate(submitted.Select(x => x.val)))
            Throw(MessagePrefix(predicateInfo));

        return false;
    }

    private static string Digest<T>(IEnumerable<(int idx, T val, string tag)> args) =>
        string.Join(", ", args.Select(x => $"i{x.idx}) {x.tag}->{ToReadable(x.val)}"));


    private static string MessagePrefix(string info) =>
        string.IsNullOrWhiteSpace(info) ? string.Empty : info + "\n";

    private static string ToReadable<T>(T val) {
        if (val is null)
            return "null";

        var text = val.ToString();
        if (string.IsNullOrEmpty(text))
            return "<empty>";

        if (string.IsNullOrWhiteSpace(text))
            return $"\"{text}\"";

        return text;
    }
}
