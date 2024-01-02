using FuncStore.Convert.Tests._️setup.Proc;
using FuncStore.Convert.Tests.Setup.Proc;
using Meas.Data.Setup.Extensions;
using Meas.Data.Setup.Formats;

namespace FuncStore.Convert.Tests.Setup.Steps;

[TestFixture]
public abstract class Arrange<TUnit> where TUnit : Enum, IConvertible
{
    static IEnumerable<object[]> MakeTestSource(Type[] catalogs, string[] args) {
        return catalogs.SelectMany(Declassify);
    }

    static IEnumerable<object[]> Declassify(Type @class) {
        var @object = Activator.CreateInstance(@class);

        var itemized = (@object as IsDataSource)?.Itemize() ?? new List<ISubject<double, string>>();
        var unitsAssigned = Units<TUnit>.SwapType(itemized);
        var expanded = Row.ByPair(unitsAssigned.Where(x => 1 < x.Entries.Count()), @class.Name);

        return expanded;
    }
}