namespace AbcExt.Metadata.Wording;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class AbbrAttribute : UniqueNamesAttribute
{
    public AbbrAttribute(string name, params string[] other)
        : base(name, other) {

        var tooLongAcronyms = Names.Where(x => 15 < x.Length).ToList();

        if (tooLongAcronyms.Any())
            Argument.Throw($"Too long for acronym:\n{string.Join(", ", tooLongAcronyms)}");
    }
}
