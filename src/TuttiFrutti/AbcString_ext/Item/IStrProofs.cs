using AbcDataOps.Text.Props;
using AbcDataOps.Text.Props.Wrapper;

namespace AbcString_ext.Item;

public static class ProofExtensions
{
    public static IBlank Is(this string val) => new BlankTraits(val);
    //public static IBlank Not(this string val) => new BlankTraits(val);

}

public static class Ext
{
    public static IBlank Not<T>(this T val) => new BlankTraits("DUMMY");
}