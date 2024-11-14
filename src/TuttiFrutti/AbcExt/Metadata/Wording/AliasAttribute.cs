namespace AbcExt.Metadata.Wording;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class AliasAttribute(string name, params string[] other) : UniqueNamesAttribute(name, other);