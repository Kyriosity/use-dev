namespace AbcStructTests.Heaps;

public class ErrorsDemo
{
    [Test]
    public void OnDuplicatedItem() {
        var heap = Bag.New(1, "first");
        Assert.Throws<UniqueConstraint>(() => heap.Put(1, "rewrite"));
    }

    [Test]
    public void OnMissingItem() {

        const string defItem = "test";

        var heap = Bag.New(defItem, true);

        Assert.Throws<EntityNotFound>(() => heap.Read<bool>("undefined"));
        Assert.Throws<EntityNotFound>(() => heap.Read<byte>("undefined"));

        _ = heap.Read<bool>(defItem);
        _ = heap.Take<bool>(defItem);
        Assert.Throws<EntityNotFound>(() => heap.Read<bool>(defItem));
    }
}
