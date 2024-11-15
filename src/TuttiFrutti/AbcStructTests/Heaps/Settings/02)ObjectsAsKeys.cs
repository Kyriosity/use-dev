using AbcDataOps.Compare.Diff;
using AbcModels.Ext.Diff;

namespace AbcStructTests.Heaps.Settings;
public class ObjectsAsKeys
{
    [Test]
    public void EqualByRef() {

        TimeOnly tOnly = new TimeOnly(1);

        var first = new Dummy { Id = "shared" };
        var other = new Dummy { Id = "shared" };

        if (first.Equals(other)) {
            var a = 1;
        }

        var bag = Bag.New(first, true);
        bag.Put(other, false);
        var another = first; another.Id = "*unique*";
        Assert.Throws<UniqueConstraint>(() => bag.Put(another, true));

        first = new Dummy { Id = "shared" };
        bag.Put(first, false);
    }

    [Test]
    public void EqualByValue() {
        NotImplemented.Throw("implement as Bag-Diff ready");
    }
}

public class Dummy : IApply
{
    public string Id { get; set; } = "";

    public override bool Equals(object? obj) => this.Lambda(obj) ?? base.Equals(obj);

    public override int GetHashCode() {
        throw new NotImplementedException();
    }
}

