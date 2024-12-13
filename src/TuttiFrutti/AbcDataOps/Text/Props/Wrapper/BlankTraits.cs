namespace AbcDataOps.Text.Props.Wrapper;

public class BlankTraits(string? value) : Wrapper<string?>(value), IBlank
{
    public bool NullOrEmpty => string.IsNullOrEmpty(_val);

    public bool NullOrWhitespace => string.IsNullOrWhiteSpace(_val);

    public bool NullEmptyOrSingleSpace => _val is null || string.Empty == _val || " " == _val; // ToDo: PROGRA SPACE !

    public bool NullEmptyOrSpaces => _val is null || string.Empty == _val; // || throw new NotImplementedException();

    public bool NullOrGrayspace => throw new NotImplementedException();
}

public abstract class Wrapper<T>(T val)
{
    protected readonly T _val = val;
}
