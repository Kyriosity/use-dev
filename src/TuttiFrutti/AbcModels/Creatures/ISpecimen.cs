using AbcModels.Creatures.Names;
using AbcModels.History;

namespace AbcModels.Creatures;
public interface ISpecimen<TName, THist> where TName : IFamily where THist : ITimeline
{

}
