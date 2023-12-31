using Hydrocarbon = Meas.Org.Tables.Chem.Compounds.Organic.Hydrocarbon.CasRegistry;
using Organoborane = Meas.Org.Tables.Chem.Compounds.Organic.Organoborane.CasRegistry;

namespace Meas.Org.Tables.Chem;
public abstract partial class Synonyms
{
    protected readonly static string methanol = nameof(Hydrocarbon.CH3OH);
    protected readonly static string carbinol = methanol;
    protected readonly static string Columbian_spirits = methanol;
    protected readonly static string MeOH = methanol;
    protected readonly static string methyl_alcohol = methanol;
    protected readonly static string wood_alcohol = methanol;
    protected readonly static string wood_spirit = methanol;
    protected readonly static string methylene_hydrat = methanol;
    protected readonly static string pyroligneous_spirit = methanol;

    protected readonly static string ethanol = nameof(Hydrocarbon.C2H5OH);
    protected readonly static string Cologne_spirit = ethanol;
    protected readonly static string alcohol = ethanol;
    protected readonly static string ethyl_hydroxide = ethanol;
    protected readonly static string ethylene_hydrate = ethanol;
    protected readonly static string ethylol = ethanol;
    protected readonly static string hydroxyethane = ethanol;
    protected readonly static string methylcarbinol = ethanol;

    protected readonly static string acetone = nameof(Hydrocarbon.CH3_2CO);
    protected readonly static string acetonum = acetone;
    protected readonly static string spirit_of_saturn = acetone;
    protected readonly static string dimethyl_ketone = acetone;
    protected readonly static string dimethyl_carbonyl = acetone;
    protected readonly static string ketone_propane = acetone;
    protected readonly static string propanone = acetone;
    protected readonly static string pyroacetic_spirit = acetone;

    protected readonly static string triethylborane = nameof(Organoborane.CH3CH2_3B);
    protected readonly static string triethylboron = triethylborane;
    protected readonly static string triethylborine = triethylborane;

    protected readonly static string jet_fuel = nameof(Hydrocarbon.jet_fuel);
    protected readonly static string aviation_kerosine = jet_fuel;
    protected readonly static string jet_A_1 = jet_fuel;
}