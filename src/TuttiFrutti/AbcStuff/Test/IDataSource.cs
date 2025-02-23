using System.Reflection;

namespace AbcStuff.Test;

public interface IDataSource
{
    static IEnumerable<object[]> Pull(Type source) => throw new NotImplementedException();
}

public interface IConstsSource : IDataSource
{
    static new IEnumerable<object[]> Pull(Type sourceClass) => sourceClass.
        GetFields(BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Static).
        Select(fld => new object[] { fld.Name, fld?.GetValue(null) });
}