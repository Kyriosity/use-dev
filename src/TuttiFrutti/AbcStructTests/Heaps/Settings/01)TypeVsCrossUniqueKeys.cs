using System.Globalization;

namespace AbcStructTests.Heaps.Settings;

public class TypeVsCrossUniqueKeys
{
    private const string id = "id1";

    [Test]
    public void SimpleDemo() {
        var bag = Bag.New();
        bag.Put("unique", false);
        bag.Put("end", "unique");
        bag.Put(id, 5);
        Assert.Throws<UniqueConstraint>(() => bag.Put(id, 11));
        bag.Put(id, "test");

        bag = Bag<CrossId>.New();
        bag.Put("unique", true);
        bag.Put("end", "unique");
        bag.Put(id, 5);
        Assert.Throws<UniqueConstraint>(() => bag.Put(id, "test"));
    }

    [TestCase(1, 2, 3, 3)]
    [TestCase(-1.234, 17.93, Math.PI, Math.PI)]
    [TestCase('a', 'b', 'c', 'c')]
    [TestCase("one", "two", "three", "three")]
    [TestCase(FileAccess.Read, FileAccess.Write, FileAccess.ReadWrite, FileAccess.ReadWrite)]
    public void MultitypeTests<TId>(TId init, TId unique, TId COPY1, TId COPY2) where TId : notnull {
        var allIn = false;

        var bag = Bag.TryOnly.New(init, "start");
        if (bag.Put(unique, nameof(unique)))
            if (bag.Put(COPY1, 747))
                if (bag.Put(COPY2, 'c'))
                    allIn = true;
        Assert.That(allIn, Is.True);
        allIn = false;

        bag = Bag<CrossId>.TryOnly.New(init, "start");
        if (bag.Put(unique, nameof(unique)))
            if (bag.Put(COPY1, 747))
                if (bag.Read(COPY1, out int _))
                    if (!bag.Put(COPY2, 'c'))
                        allIn = true;
        Assert.That(allIn, Is.True);

        bag.Take(COPY1, out int _);
        bag.Put(COPY2, 'c');
    }

    [Test]
    public void ReferencesTests() {
        var birds = new Writing {
            Title = "The Birds of America", YearPublishedAD = 1827,
            Tongues = [new CultureInfo("en-US")], Authors = [
                new Person<INames>(new Names { First = "John James", Last = "Audubon" }) { Birth = new DateOnly(1785, 4, 26) } ],
            Notes = "March.2000: a copy sold for $8.8M - record for any book at auction"
        };

        var island = new Writing {
            Title = "L'Île mystérieuse", YearPublishedAD = 1875,
            Tongues = [new CultureInfo("fr-FR")], Authors = [
                new Person<INames>(new Names { First = "Jules", Last = "Verne" }) { Birth = new DateOnly(1828, 2, 8) } ]
        };


        var bag = Bag<CrossId>.New(birds, "most expensive book on sale");
        bag.Put(island, true);
    }

    [Test]
    public void CollsTests() {
        Assert.Ignore("Implement on demand");
    }
}

public class Writing
{
    public required string Title { get; set; }

    public required short YearPublishedAD { get; set; }

    public required IEnumerable<CultureInfo> Tongues { get; set; } = [];
    public required IEnumerable<IPerson> Authors { get; set; } = [];
    public string Abstract { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;

}

public class Person<TName> : IPerson where TName : INames
{
    public Person(TName names) {
        Names = names;
    }

    public INames Names { get; set; }

    public DateOnly? Birth { get; set; } = null;
}

public interface IPerson
{
    INames Names { get; set; }
}

public interface INames
{
    string First { get; set; }
    string Last { get; set; }
}

public class Names : INames
{
    public required string First { get; set; } = "";
    public required string Last { get; set; } = "";
}