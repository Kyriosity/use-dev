using MeasOrg.Tables.Chem.Compounds.Inorganic.Nitrates;

namespace MeasOrg.Tables.Chem;
public abstract partial class Synonyms
{
    protected static readonly string potassium_nitrate = nameof(CasRegistry.KNO3);
    protected static readonly string saltpeter = potassium_nitrate;
    protected static readonly string saltpetre = potassium_nitrate;
    protected static readonly string nitrate_of_potash = potassium_nitrate;

    protected static readonly string sodium_nitrate = nameof(CasRegistry.NaNO3);
    protected static readonly string soda_niter = sodium_nitrate;
    protected static readonly string cubic_niter = sodium_nitrate;
    protected static readonly string Peru_saltpepper = sodium_nitrate;
    protected static readonly string E251 = sodium_nitrate;
}
