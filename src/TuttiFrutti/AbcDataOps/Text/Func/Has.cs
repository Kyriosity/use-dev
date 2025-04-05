namespace AbcDataOps.Text.Func;
public class Has
{
    public static readonly Func<string, bool> ControlChars = subj =>
        subj.ToCharArray().Any(char.IsControl);
}

public class HasNo
{
    public static readonly Func<string, bool> Controls = subj => !Has.ControlChars(subj);
}
