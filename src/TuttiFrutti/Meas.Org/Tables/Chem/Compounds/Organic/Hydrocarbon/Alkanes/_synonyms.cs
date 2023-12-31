
using Meas.Org.Tables.Chem.Compounds.Organic.Hydrocarbon.Alkanes;

namespace Meas.Org.Tables.Chem;
public abstract partial class Synonyms
{
    protected readonly static string methane = nameof(CasRegistry.CH4);
    protected readonly static string marsh_gas = methane;
    protected readonly static string natural_gas = methane;
    protected readonly static string carbon_tetrahydride = methane;
    protected readonly static string CH4 = methane;

    protected readonly static string ethane = nameof(CasRegistry.C2H6);
    protected readonly static string propane = nameof(CasRegistry.C3H8);
    protected readonly static string butane = nameof(CasRegistry.C4H10);
    protected readonly static string pentane = nameof(CasRegistry.C5H12);
    protected readonly static string hexane = nameof(CasRegistry.C6H14);
    protected readonly static string heptane = nameof(CasRegistry.C7H16);
    protected readonly static string actane = nameof(CasRegistry.C8H18);
    protected readonly static string noane = nameof(CasRegistry.C9H20);
    protected readonly static string decane = nameof(CasRegistry.C10H22);
    protected readonly static string undecane = nameof(CasRegistry.C11H24);
    protected readonly static string dodecane = nameof(CasRegistry.C12H26);
}