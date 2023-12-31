using Meas.Org.Tables.Chem.Compounds.Inorganic.Oxides;

namespace Meas.Org.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string water = nameof(CasRegistry.H2O);
    protected static readonly string hydrogen_oxide = water;
    protected static readonly string hydrogen_hydroxide = water;
    protected static readonly string hydroxylic_acid = water;
    protected static readonly string H2O = water;
    protected static readonly string dihydrogen_monoxide = water; // parody name

    protected static readonly string nitrous_oxide = nameof(CasRegistry.N2O);
    protected static readonly string protoxide_of_nitrogen = nitrous_oxide;
    protected static readonly string hyponitrous_oxide = nitrous_oxide;
    protected static readonly string dinitrogen_monoxide = nitrous_oxide;
    protected static readonly string laughung_gas = nitrous_oxide;

    protected static readonly string carbon_dioxyde = nameof(CasRegistry.CO2);
    protected static readonly string dry_ice = carbon_dioxyde;
    protected static readonly string CO2 = carbon_dioxyde;

    protected static readonly string carbon_monoxyde = nameof(CasRegistry.CO);
    protected static readonly string carbonic_oxid_gas = carbon_monoxyde;
    protected static readonly string carbon_protoxide = carbon_monoxyde;
    protected static readonly string oxygenated_carbon = carbon_monoxyde;
    protected static readonly string Rauchgas = carbon_monoxyde;
    protected static readonly string Dowson_gas = carbon_monoxyde;
    protected static readonly string carbonyl = carbon_monoxyde;
    protected static readonly string carbate = carbon_monoxyde;
    protected static readonly string CarbonII_oxide = carbon_monoxyde;

    protected static readonly string cupric_oxide = nameof(CasRegistry.CuO);
    protected static readonly string CopperII_oxide = cupric_oxide;

    protected static readonly string cuprous_oxide = nameof(CasRegistry.Cu2O);
    protected static readonly string CopperI_oxide = cuprous_oxide;
    protected static readonly string dicopper_oxide = cuprous_oxide;
    protected static readonly string cuprite = cuprous_oxide;
    protected static readonly string red_copper_oxide = cuprous_oxide;

}
