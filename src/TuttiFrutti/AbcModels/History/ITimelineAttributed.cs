namespace AbcModels.History;
public interface ITimelineAttributed<TStamp, TAttr> : ITimeline<(TStamp time, TAttr attr)>;
// ToDo: rename Attributed for less ambigous

