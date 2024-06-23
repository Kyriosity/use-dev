namespace AbcModelsTests;

public class Tests
{
    [Test]
    public void Persons() {

        var pers = new Person<INames_Edit> { Names = new Names_Edit { First = "uniqNom" } };

        pers.Names.First = "ffffffff";

        var read = (IPerson<INames>)pers;
        var moment = read.Names.First;

        Person<INames> reader = new() { Names = new Names_Edit { First = "Abraham" } };

        var firstReader = reader.Names.First;

        //reader = (IPerson<INames_Edit>)pers;
        ///DEL var a = 1;
        //read.Names.First = "ff";

    }
}

public interface INames
{
    string First { get; }
}

public interface INames_Edit : INames
{
    new string First { get; set; }
}

public class Person<TNames> : IPerson<TNames>
{
    public TNames Names { get; set; }

    public byte Age { get; set; } = 128;
}

public interface IPerson<out TNames>
{
    TNames Names {
        get;
    }
}

public class Names_Edit : INames_Edit
{
    public string First { get; set; } = "Lappo";
}