using AbcExt.DataOps.Compare;
namespace AbcExt.Metadata.Wording;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class AliasAttribute : Attribute
{
    public AliasAttribute(string otherName, params string[] otherNames) {

        string[] aliases = [otherName, .. otherNames];
        // Argument.ThrowIfAny(non_mean, names); // ILLEGAL LEAD. TRAIL
        DuplicatedArgument.ThrowIfAny(Equal.Loose(), aliases);

        Names = aliases;
    }

    public string[] Names { get; init; }
}
