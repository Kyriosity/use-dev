namespace AbcExt.Metadata.Wording;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class AliasAttribute : UniqueNamesAttribute
{
    public AliasAttribute(string name, params string[] other) : base(name, other) { }
}
