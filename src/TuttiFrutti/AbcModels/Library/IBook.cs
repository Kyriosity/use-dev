using AbcModels.Bits.Reviewed;
using AbcModels.History.Opuses;
using AbcModels.Library.Ids;

namespace AbcModels.Library;
public interface IBook<TId, TTitle, IHist, TNote, TAbstr> : IWriting<TId, TTitle, IHist, TNote, TAbstr>
    where TId : ISBN where TTitle : ITitled where IHist : IIssuedYearsAD where TNote : ICommented where TAbstr : ICommented;


public class Book<TId, TTitle, IHist, TNote, TAbstr> : Writing<TId, TTitle, IHist, TNote, TAbstr>, IBook<TId, TTitle, IHist, TNote, TAbstr>
    where TId : ISBN where TTitle : ITitled where IHist : IIssuedYearsAD where TNote : ICommented where TAbstr : ICommented
{

    public override TId? Id { get => base.Id; set => base.Id = value; }
}

