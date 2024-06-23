using AbcModels.Creatures.Names;

namespace AbcModels.Creatures;

public interface IPerson<TNames> where TNames : IFamily
{
    TNames Names { get; }

    IHap Born { get; }
}


public class Person : IPerson<IFamily_Edit>
{
    public IFamily_Edit Names { get; set; }
    public IHap Born { get; set; }
}
