using AbcExt.DataOps.Compare.Diff;

namespace AbcModels.Ext.Diff;
public static class Extensions
{
    public static bool? Lambda(this IApply source, object? target) {
        var unnull = ArgumentNull.DenyOrThrow(target);

        return true;
    }

    public static bool? Lambda(this IApply source, IApply? target) =>
        true;
}
