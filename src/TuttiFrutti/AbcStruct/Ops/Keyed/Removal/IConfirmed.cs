namespace AbcStruct.Ops.Keyed.Removal;
public interface IConfirmed<in TId> where TId : notnull
{
    void EnsureNone(TId id, params TId[] nextIds);
}
