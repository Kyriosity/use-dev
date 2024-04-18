namespace AbcExt.Metadata;
public abstract class UniqueNamesAttribute : Attribute
{
    protected UniqueNamesAttribute(string name, params string[] other) {
        string[] names = [name, .. other];

        // ToDesign: wording utilites and multi-Argument with reporting
        // Argument.ThrowIfAny(Wording.NoLeadTrail, Wording.Normal, aliases);

        DuplicatedArgument.ThrowIfAny(Equal.Loose(), names);

        Names = names;
    }
    public string[] Names { get; init; }
}
