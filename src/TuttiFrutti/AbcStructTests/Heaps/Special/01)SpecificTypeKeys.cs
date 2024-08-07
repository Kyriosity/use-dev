namespace AbcStructTests.Heaps.Special;
public class SpecificValuesId
{
    [Test]
    public void NullableValues() {
        const string Id = "NullId";
        var bag = Bag.New();

        bag.Put<bool>(Id, true);
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
}
