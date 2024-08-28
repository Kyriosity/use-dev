using AbcChrono;
using AbcModels.Creatures;
using AbcModels.Creatures.Names;

namespace AbcModels.Dir;

public class Creatures : _basal
{
    public static IDictionary<string, IPerson<IFamily_Edit>> Persons =
        new Dictionary<string, IPerson<IFamily_Edit>> {

            ["da Vinci"] = null,

            ["Raphael"] = new Person { // Raffaello Sanzio da Urbino
                Names = NotImplemented.ToDo<IFamily_Edit>(null, "West, East,..."),
                Born = Era.Common.At.circa().April(6).Year(1483)
            }
        };
}


