using Meas.Org.Tables.Chem.Compounds.Inorganic.Chlorides;

namespace Meas.Org.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string sodium_chloride = nameof(CasRegistry.NaCl);
    protected static readonly string table_salt = sodium_chloride;
    protected static readonly string halite = sodium_chloride;
    protected static readonly string saline = sodium_chloride;

    protected static readonly string potassium_chloride = nameof(CasRegistry.NaCl);
    protected static readonly string sylvite = potassium_chloride;
    protected static readonly string muriate_of_potash = potassium_chloride;
}
