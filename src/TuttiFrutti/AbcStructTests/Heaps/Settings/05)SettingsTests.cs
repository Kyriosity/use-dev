namespace AbcStructTests.Heaps.Settings;

public class TypeVsCrossIdsTests
{
    private const string id = "id1";

    [Test]
    public void SimpleDemo() {
        var bag = Bag.New();
        bag.Put("unique", false);
        bag.Put("end", "unique");
        bag.Put(id, 5);
        bag.Put(id, "test");

        bag = Bag<CrossId>.New();
        bag.Put("unique", true);
        bag.Put("end", "unique");
        bag.Put(id, 5);
        Assert.Throws<UniqueConstraint>(() => bag.Put(id, "test"));
    }

    [TestCase(1, 2, 3, 4, 4)]
    [TestCase("1", "2", "3", "4", "4")]
    public void MultitypeTests<TId>(TId init, TId unique, TId other, TId COPY1, TId COPY2) where TId : notnull {
        var allIn = false;

        var bag = Bag.TryOnly.New(init, "start");
        if (bag.Put(unique, nameof(unique)))
            if (bag.Put(other, sampleEnum))
                if (bag.Put(COPY1, 747))
                    if (bag.Put(COPY2, 'c'))
                        allIn = true;
        Assert.IsTrue(allIn); allIn = false;

        bag = Bag<CrossId>.TryOnly.New(init, "start");
        if (bag.Put(unique, nameof(unique)))
            if (bag.Put(other, sampleEnum))
                if (bag.Put(COPY1, 747))
                    if (bag.Read(COPY1, out int _))
                        if (!bag.Put(COPY2, 'c'))
                            allIn = true;
        Assert.IsTrue(allIn);

        bag.Take(COPY1, out int _);
        bag.Put(COPY2, 'c');
    }

    private const FileAccess sampleEnum = FileAccess.ReadWrite;
}
