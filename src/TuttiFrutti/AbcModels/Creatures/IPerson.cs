using AbcModels.Creatures.Names;
using AbcModels.History;

namespace AbcModels.Creatures;

public interface IPerson<TNames> where TNames : IFamily
{
    TNames Names { get; init; }
}

public class Person<TNames, TTime> : IPerson<TNames>
    where TNames : IFamily where TTime : ITimeline
{
    public required TNames Names { get; init; }
}
