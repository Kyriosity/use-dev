using AbcExt.DataOps.Compare;
namespace AbcExt.Metadata.Wording;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class AliasAttribute : Attribute
{
    public AliasAttribute(string otherName, params string[] otherNames) {

        string[] aliases = [otherName, .. otherNames];


        // ToDesign: wording utilites and multi-Argument with reporting
        // Argument.ThrowIfAny(Wording.NoLeadTrail, Wording.Normal, aliases);

        // Argument.ThrowIfAny(non_mean, names); // ILLEGAL LEAD. TRAIL
        DuplicatedArgument.ThrowIfAny(Equal.Loose(), aliases);

        Names = aliases;
    }

    public string[] Names { get; init; }
}
