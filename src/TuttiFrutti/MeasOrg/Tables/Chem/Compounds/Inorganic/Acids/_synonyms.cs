using MeasOrg.Tables.Chem.Compounds.Inorganic.Acids;

namespace MeasOrg.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string nitric_acid = nameof(CasRegistry.HNO3);
    protected static readonly string aqua_fortis = nitric_acid;
    protected static readonly string eau_fortis = nitric_acid;
    protected static readonly string spirit_of_niter = nitric_acid;
    protected static readonly string hydrogen_nitrate = nitric_acid;
    protected static readonly string acidum_nitricum = nitric_acid;
    protected static readonly string HNO3 = nitric_acid;

    protected static readonly string hydrofluoric_acid = nameof(CasRegistry.HF);
    protected static readonly string fluorhydric_acid = hydrofluoric_acid;
    protected static readonly string hydronium_fluoride = hydrofluoric_acid;
    protected static readonly string HF = hydrofluoric_acid;

    protected static readonly string sulfuric_acid = nameof(CasRegistry.H2SO4);
    protected static readonly string oil_of_vitriol = sulfuric_acid;
    protected static readonly string hydrogen_sulfate = sulfuric_acid;
    protected static readonly string H2SO4 = sulfuric_acid;
}
