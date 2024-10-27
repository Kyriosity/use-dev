using System.Globalization;

namespace AbcStructTests.Heaps.Special;
public class SpecificValuesId
{
    [Test]
    public void NullableValues() {

        var cult = CultureInfo.CurrentCulture;

        var rtv = typeof(string).Assembly.ImageRuntimeVersion;
        var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        const string Id = "NullId";
        var bag = Bag.New();

        bag.Put(Id, true);
        bag.Put<bool?>(Id, null);
        Assert.That(bag.Read<bool>(Id), Is.True);
        Assert.That(bag.Read<bool?>(Id), Is.Null);

        bag.Put<int?>(Id, null);
        // bag.Put<int>(Id, null); // won't compile
        Assert.Throws<EntityNotFound>(() => bag.Take<int>(Id));
        Assert.That(bag.Take<int?>(Id), Is.Null);

        bag.Put<object>(Id, null);
        Assert.That(bag.Take<object>(Id), Is.Null);

        bag.Put<string?>(Id, "can but isn't null");
        Assert.That(bag.Take<string?>(Id), Is.Not.Null);

        bag.Put<string>(Id, null);
        Assert.That(bag.Take<string>(Id), Is.Null);
    }

    [Test]
    public void ObjectCasting() {
        Assert.Ignore("implement on demand");
    }

    [Test]
    public void TUPLE2MOVE() {
        // SEE BELOW -> PLUS OTHER OPs apply like ==

        int tester = ((int?)1).Value;
        var res = 1 == ((int?)1).Value;

        var book = new Book { Title = "Birds of America", Id = 1 };
        var book2 = book with { Id = 2 };

        var obj = book as object;

        var man = new { name = new { first = "John", last = "Smith" } };
        var spouse = man with { name = new { first = "Helene", last = "Smithg" } };
    }
}

struct Book : IBook
{
    public string Title { get; set; }

    public int Id { get; set; }

    public uint Year { get; set; }
}

interface IBook { uint Year { get; } }