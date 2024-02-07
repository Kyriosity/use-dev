using MeasOrg.Tables.Chem.Compounds.Inorganic;

namespace MeasOrg.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string ammonia = nameof(CasRegistry.NH3);
    protected static readonly string hydrogen_nitride = ammonia;
    protected static readonly string R717 = ammonia;
    protected static readonly string amidogen = ammonia;
    protected static readonly string hydrogen_amine = ammonia;

    protected static readonly string dioxygen = nameof(CasRegistry.O2);
    protected static readonly string O2 = dioxygen;

    protected static readonly string Ozone = nameof(CasRegistry.O3);
    protected static readonly string O3 = Ozone;

    protected static readonly string white_phosphorus = nameof(CasRegistry.P4);
    protected static readonly string PH4 = white_phosphorus;
}
