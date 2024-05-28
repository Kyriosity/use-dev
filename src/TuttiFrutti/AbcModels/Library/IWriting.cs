using AbcModels.Bits.Reviewed;
using AbcModels.Creatures;
using AbcModels.Creatures.Names;
using AbcModels.History.Opuses;

namespace AbcModels.Library;

public interface IWriting<TId, TDenom, THist, TNotes, TAbstr> where TId : IUnique where TDenom : IDenom
    where THist : IComposed where TNotes : ICommented where TAbstr : ICommented;

public abstract class Writing<TId, TDenom, THist, TNote, TAbstr> : IWriting<TId, TDenom, THist, TNote, TAbstr>
    where TId : IUnique where TDenom : IDenom where THist : IComposed where TNote : ICommented where TAbstr : ICommented
{
    virtual public TId? Id { get; set; } = default;
    virtual public required TDenom Title { get; set; }

    virtual public required THist Timeline { get; set; }

    virtual public required IEnumerable<CultureInfo> Tongues { get; set; } = [];
    virtual public required IEnumerable<IPerson<IFamily>> Authors { get; set; } = [];
    virtual public TAbstr? Abstract { get; set; } = default;
    virtual public TNote? Notes { get; set; } = default;
}

