using Abc.Coll.Gtor;
namespace Test_Learn.Abc.Coll.Access;

public class Items
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void GetAll(IAdjustedItemsBuilder builder) {
        var coll = builder.Of<string>();
        Assert.That(coll.Items, Has.Count.EqualTo(0));
        Assert.That(coll.Items.ToArray(), Is.Not.Null);

        var words = builder.Of(Providers.LoremIpsum_SplitToWords);
        Assert.That(string.Join(" ", words.Items), Is.EqualTo(Dummies.Text.LoremIpsum));
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void Index(IAdjustedItemsBuilder builder) {
        var coll = builder.Of(Sequences.ZeroToEleven);

        for (int i = 0; i < coll.Items.Count; i++)
            Assert.That(coll[i], Is.EqualTo(i));
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public static void IndexBack(IAdjustedItemsBuilder builder) {
        var coll = builder.Of(Sequences.ZeroToEleven);
        const int indexOfLast = -1;
        Assert.That(Sequences.ZeroToEleven.Last(), Is.EqualTo(coll[indexOfLast]));
        int indexOfFirstReverse = -coll.Items.Count;
        Assert.That(Sequences.ZeroToEleven.First(), Is.EqualTo(coll[indexOfFirstReverse]));

        var depth = -coll.Items.Count;
        const int indexOfPenult = -2;
        for (int i = indexOfPenult; i <= depth; i--)
            Assert.That(coll[i], Is.EqualTo(-i));
    }
}

public class Mistakes
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public static void IndexOutside(IAdjustedItemsBuilder builder) {
        var coll = builder.Of(Providers.LoremIpsum_SplitToWords);

        Assert.That(() => coll[coll.Items.Count], Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => coll[-1 - coll.Items.Count], Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public static void IndexEmpty(IAdjustedItemsBuilder builder) {
        var emptyColl = builder.Of<int>();
        Assert.That(() => emptyColl[0], Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}
