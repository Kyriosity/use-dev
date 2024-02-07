using MeasOrg.Tables.Chem.Compounds.Organic.Hydrocarbon.Alkanes;

namespace MeasOrg.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string methane = nameof(CasRegistry.CH4);
    protected static readonly string marsh_gas = methane;
    protected static readonly string natural_gas = methane;
    protected static readonly string carbon_tetrahydride = methane;
    protected static readonly string CH4 = methane;

    protected static readonly string ethane = nameof(CasRegistry.C2H6);
    protected static readonly string propane = nameof(CasRegistry.C3H8);
    protected static readonly string butane = nameof(CasRegistry.C4H10);
    protected static readonly string pentane = nameof(CasRegistry.C5H12);
    protected static readonly string hexane = nameof(CasRegistry.C6H14);
    protected static readonly string heptane = nameof(CasRegistry.C7H16);
    protected static readonly string actane = nameof(CasRegistry.C8H18);
    protected static readonly string noane = nameof(CasRegistry.C9H20);
    protected static readonly string decane = nameof(CasRegistry.C10H22);
    protected static readonly string undecane = nameof(CasRegistry.C11H24);
    protected static readonly string dodecane = nameof(CasRegistry.C12H26);
}