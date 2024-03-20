namespace AbcStructTests.Heaps.Special;
public class SpecialValues_Tests
{
    [Test]
    public void NullableValues_Demo() {
        const string Id = "NullId";
        var bag = Bag.New();

        bag.Put<bool>(Id, true);
        bag.Put<bool?>(Id, null);
        Assert.IsTrue(bag.Read<bool>(Id));
        Assert.IsNull(bag.Read<bool?>(Id));

        bag.Put<int?>(Id, null);
        // bag.Put<int>(Id, null); // won't compile
        Assert.Throws<EntityNotFound>(() => bag.Take<int>(Id));
        Assert.IsNull(bag.Take<int?>(Id));

        bag.Put<object>(Id, null);
        Assert.IsNull(bag.Take<object>(Id));

        bag.Put<string?>(Id, "can but isn't null");
        Assert.IsNotNull(bag.Take<string?>(Id));

        bag.Put<string>(Id, null);
        Assert.That(bag.Take<string>(Id), Is.Null);
    }

    [Test]
    public void TestCasting() {
        Assert.Ignore("implement on demand");
    }
}
