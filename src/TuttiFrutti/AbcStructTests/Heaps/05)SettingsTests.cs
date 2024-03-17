using AbcStruct.Heap.Multitype.Implement;

namespace AbcStructTests.Heaps;
public class SettingsTests
{
    [Test]
    public void UniqueIdsAcross() {
        var bag = Bag.New();
        bag.Put("id", 5);
        bag.Put("id", "test");

        bag = Bag<GlobalId>.New();
        bag.Put("id", 5);
        Assert.Throws<UniqueConstraint>(() => bag.Put("id", "test"));
    }
}
