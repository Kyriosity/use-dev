namespace AbcStruct.Heap.Core;
public class CrossId : Default
{
    public override bool Add<TId, T>(TId id, T? val) where T : default {
        if (Ids is null)
            Ids = new List<TId> { id };
        else {
            var ids = ((List<TId>)Ids).ToList();
            var twins = ids.Where(x => x.Equals(id)).ToList();
            if (0 < twins.Count)
                return false; // ToDesign: return error??

            ids.Add(id); Ids = ids;
        }
        return base.Add(id, val);
    }


    public override bool Remove<TId, T>(TId id) {
        var ids = ((List<TId>)Ids).ToList();

        if (!ids.Remove(id))
            return false; // ToDesign: exception code

        Ids = ids;

        return base.Remove<TId, T>(id);
    }

    protected IEnumerable Ids { get; set; }

}
