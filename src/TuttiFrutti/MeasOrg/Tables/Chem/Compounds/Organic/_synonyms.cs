using MeasOrg.Tables.Chem.Compounds.Organic.Hydrocarbon;

namespace MeasOrg.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string methanol = nameof(CasRegistry.CH3OH);
    protected static readonly string carbinol = methanol;
    protected static readonly string Columbian_spirits = methanol;
    protected static readonly string MeOH = methanol;
    protected static readonly string methyl_alcohol = methanol;
    protected static readonly string wood_alcohol = methanol;
    protected static readonly string wood_spirit = methanol;
    protected static readonly string methylene_hydrat = methanol;
    protected static readonly string pyroligneous_spirit = methanol;

    protected static readonly string ethanol = nameof(CasRegistry.C2H5OH);
    protected static readonly string Cologne_spirit = ethanol;
    protected static readonly string alcohol = ethanol;
    protected static readonly string ethyl_hydroxide = ethanol;
    protected static readonly string ethylene_hydrate = ethanol;
    protected static readonly string ethylol = ethanol;
    protected static readonly string hydroxyethane = ethanol;
    protected static readonly string methylcarbinol = ethanol;

    protected static readonly string acetone = nameof(CasRegistry.CH3_2CO);
    protected static readonly string acetonum = acetone;
    protected static readonly string spirit_of_saturn = acetone;
    protected static readonly string dimethyl_ketone = acetone;
    protected static readonly string dimethyl_carbonyl = acetone;
    protected static readonly string ketone_propane = acetone;
    protected static readonly string propanone = acetone;
    protected static readonly string pyroacetic_spirit = acetone;

    protected static readonly string triethylborane = nameof(Compounds.Organic.Organoborane.CasRegistry.CH3CH2_3B);
    protected static readonly string triethylboron = triethylborane;
    protected static readonly string triethylborine = triethylborane;

    protected static readonly string jet_fuel = nameof(CasRegistry.jet_fuel);
    protected static readonly string aviation_kerosine = jet_fuel;
    protected static readonly string jet_A_1 = jet_fuel;
}