namespace AbcDataOps.Text.Func;

public class Is
{
    public static readonly Func<string, bool> Spaces = subj =>
        subj is not "" && subj.All(chr => ' ' == chr);

    public static readonly Func<string, bool> Whitespace = subj =>
        subj is not "" && string.IsNullOrWhiteSpace(subj);

    public static readonly Func<string, bool> Grayspace =
        subj => throw new NotImplementedException("reserved for discussions");
}

