namespace AbcStructTests.Heaps;
public class ComplexTypesKeys
{
    [Test]
    public void TupleId() {
        var id1 = (num: 1, nom: "uno");

        var bag = Bag.New(id1, true);
        Assert.IsTrue(bag.Read<bool>(id1));

        bag.Put(id1, "variant 2");

        var id2 = (num: 1, nom: "UNO");
        bag.Put(id2, true);
    }

    [Test]
    public void ObjecId() {
        Assert.Fail("will be added soon");
    }

    [Test]
    public void CollectionId() {
        Assert.Ignore("implement on demand");
    }
}
