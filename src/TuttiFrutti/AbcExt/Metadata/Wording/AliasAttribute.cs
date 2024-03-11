namespace AbcExt.Metadata.Wording;
public class AliasAttribute : Attribute
{
    public AliasAttribute(string otherName, params string[] otherNames) {

        string[] aliases = [otherName, .. otherNames];

        //Argument.ThrowIfAny(non_mean, names); // ILLEGAL LEAD. TRAIL
        //DuplicatedArgument.LooseEqual(aliases);

        Names = aliases;
    }


    public string[] Names { get; init; }
}
