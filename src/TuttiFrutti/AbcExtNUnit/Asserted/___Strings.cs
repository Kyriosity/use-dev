namespace AbcExtNUnit.Asserted;
public class Strings : Numbers
{
    protected const string? NullStr = null;

    public string Empty {
        get => string.Empty;
        set => Assert.That(value, Is.Empty);
    }
}
