using AbcExt.Wording;


namespace AbcExt.Errors.Shortcuts;
public abstract class MultiparameterConditional<TExc>(string? message = "", Exception? inner = null)
    : Multiparameter<TExc>(message, inner) where TExc : Exception
{
    protected static bool OnCondition<T>(Predicate<T> predicate, Func<int, int, bool> countTrigger, (T val, string tag)[] args) {
        var submitted = args.Where(x => x.tag != Arg.NotSubmitted).ToList();
        var match = submitted.Select((x, i) => (idx: i, x.val, x.tag))
            .Where(x => predicate(x.val)).ToList();

        if (countTrigger(match.Count, submitted.Count))
            Throw(Digest(match));

        return false;
    }

    private static string Digest<T>(IEnumerable<(int idx, T val, string tag)> args) =>
        string.Join(", ", args.Select(x =>
            $"{x.idx}) {x.tag}->{ToReadable(x.val)}"));

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
