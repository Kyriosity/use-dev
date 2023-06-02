using Abc.Ltd;
using Abc.Mk;
using Abc.Test.Setup;
namespace Abc.Test_Learn.Properties;

public class VariedPropTests
{
    [Test, TestCase(-111)]
    public void CastImplicit<T>(T item) {
        IItem<T> holder = new SealedHolder<T>();
        //Assert.That(item, Is.Not.Eq);

        var initialized = new ItemedHolder<T> { Item = item };

        holder = initialized;
        Assert.That(initialized.Item, Is.EqualTo(item));

        //var mutable = Mock.Create<IMutableItem<int>>();
        //mutable.Item = 11;
        //holder = mutable;
        //var val = mutable.Item;
        //Assert.That(holder.Item, Is.EqualTo(11));
    }

    [Test]
    public void CastExplicit() {
        IItem<int> holder = Mock.Create<IItem<int>>();
        Mock.Arrange(() => holder.Item).Returns(7);

        IMutableItem<int> mutable = Mock.Create<IMutableItem<int>>();
        mutable.Item = -11;

        IMutableItem<int> BackToMutable = (IMutableItem<int>)holder;

        var val = BackToMutable.Item;
    }

    [Test, TestCaseSource(typeof(TestArgs), nameof(TestArgs.MotleyTypes))]
    public void KeepCastedValue<T>(T value) {
        var limit = Mock.Create<IUpperLimit<T>>(Behavior.Strict);
        Mock.Arrange(() => limit.Max).Returns(value);

        var limitable = Mock.Create<IUpperLimitable<T>>();
        limitable.Max = 7;
    }
}

public class Mistakes
{
    [Test]
    public void Upcast() {

        // Assert.That NULL
    }
}


public class Book<T, Prop> : IItemed<string> where Prop : Accessor<T>
{
    public Prop Name;

    public string? Item { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
}
