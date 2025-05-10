using AbcDataOps.Compare.Diff;

namespace AbcModels.Ext.Diff;
public static class Extensions
{
    extension(IApply source)
    {
        public bool? Lambda(object? target) {
            var unnull = ArgumentNull.DenyOrThrow(target);

            return true;
        }

        public bool? Lambda(IApply? target) =>
            true;
    }
}
