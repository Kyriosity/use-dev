namespace AbcRefl.Metadata;
public abstract class UniqueNamesAttribute : Attribute
{
    protected UniqueNamesAttribute(string name, params string[] other) {
        string[] names = [name, .. other];

        var emptyCount = names.Where(x => 0 == x.Trim().Length).Count(); // ToDesig FULL STR CHECK - x.Is.NullOrEMPTOID)
        if (emptyCount is not 0)
            throw new ArgumentException($"Names empty/supplied: {emptyCount}/{names.Count()}");

        // ToDesign: wording utilites and multi-Argument with reporting
        // Argument.ThrowIfAny(Wording.NoLeadTrail, Wording.Normal, aliases);

        //if (names.Are/Not.Unique<IEqualityComparer>) {
        //if (DataOps.)
        //throw new ArgumentException(Equal.Loose, names);

        Names = names;
    }
    public string[] Names { get; init; }
}
