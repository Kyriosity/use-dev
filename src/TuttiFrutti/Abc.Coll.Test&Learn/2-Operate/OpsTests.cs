using Abc.Coll.Gtor;
using Abc.Test.Data;

namespace Test_Learn.Abc.Coll.Operate;

public class Addition
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void Append(IAdjustedItemsBuilder builder) {
        var pi = builder.Of<double>();
        pi.Add(Math.PI);
        Assert.That(pi.Items, Has.Count.EqualTo(1));

        var words = builder.Of<string>();
        var loremIpsumSplit = Dummies.Text.LoremIpsum.Split();
        words.Add(loremIpsumSplit);
        Assert.That(words.Items, Has.Count.EqualTo(loremIpsumSplit.Length).And.Count.GreaterThan(1));

        var swift = builder.Of("veni", "vidi");
        swift.Add("vici");
        Assert.That(string.Join(", ", swift.Items), Is.EqualTo("veni, vidi, vici"));
    }
}

public class Removal
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void ByIndexSingle(IAdjustedItemsBuilder builder) {
        var coll = builder.Of('A', 'B', 'C');
        coll.RemoveAt(0);
        Assert.That(coll.Items.SequenceEqual(new[] { 'B', 'C' }));

        coll = builder.Of('A', 'B', 'C');
        coll.RemoveAt(0, 1);
        Assert.That(coll.Items.SequenceEqual(new[] { 'B', 'C' }));

        coll = builder.Of('A', 'B', 'C');
        coll.RemoveAt(1);
        Assert.That(coll.Items.SequenceEqual(new[] { 'A', 'C' }));

        coll = builder.Of('A', 'B', 'C');
        coll.RemoveAt(2);
        Assert.That(coll.Items.SequenceEqual(new[] { 'A', 'B' }));

    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void ByIndexRange(IAdjustedItemsBuilder builder) {
        var accu = builder.Of(Dummies.Sequences.ZeroToEleven);
        const int numToKeep = 4;
        accu.RemoveAt(2, accu.Items.Count - numToKeep);
        Assert.That(accu.Items.SequenceEqual(new[] { 0, 1, 10, 11 }));

        accu = builder.Of(Dummies.Sequences.ZeroToEleven);
        accu.RemoveAt(0, accu.Items.Count);
        Assert.That(accu.Items, Has.Count.EqualTo(0));
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void FromEdge(IAdjustedItemsBuilder builder) {
        var coll = builder.Of(1, 2, 3);
        coll.RemoveFirst();
        Assert.That(coll.Items.SequenceEqual(new[] { 2, 3 }));
        coll.RemoveLast();
        Assert.That(coll.Items.SequenceEqual(new[] { 2 }));

        var debut = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var middle = new[] { -78, -79, -80, -81, -82, -83, -84, -85 };
        var end = new[] { 707, 737, 747, 777, 787 };
        coll = builder.Of(debut.Concat(middle).Concat(end));

        coll.RemoveFirst(debut.Length);
        Assert.That(coll.Items.SequenceEqual(middle.Concat(end)), Is.True);
        coll.RemoveLast(end.Length);
        Assert.That(coll.Items.SequenceEqual(middle), Is.True);
    }
}

public class ConditionalRemoval
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void ByPredicate(IAdjustedItemsBuilder builder) {
        var words = builder.Of(Dummies.Text.LoremIpsum.Split());
        words.Remove(x => true);
        Assert.That(words.Items, Has.Count.EqualTo(0));

        var indeces = builder.Of(Dummies.Sequences.ZeroToEleven);
        indeces.Remove(x => x is < 3 or > 5, out var numRemoved);
        Assert.That(indeces.Items.SequenceEqual(new[] { 3, 4, 5 }));
    }
}

public class Chained
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void Add(IAdjustedItemsBuilder builder) {
        var math = builder.Of<double>();
        math.Add(Math.PI).Add(Math.E).Add(Math.Tau);
        Assert.That(math.Items.SequenceEqual(new[] { Math.PI, Math.E, Math.Tau }), Is.True);

        var words = builder.Of<string>();
        var fox = new[] { "quick", "brown", "fox" };
        words.Add("the").Add(fox).
            Add("jumps", "over", "the", "lazy", "dog");

        Assert.That(string.Join(" ", words.Items), Is.EqualTo(Dummies.Text.PangramEn));
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void Remove(IAdjustedItemsBuilder builder) {
        var metals = builder.Of("lead",
            "silver", "gold", "arsenic", "cadmium", "platinum",
            "mercury", "chromium", "beryllium");
        metals.RemoveLast(3).
            RemoveAt(3, 2).
            RemoveFirst();
        Assert.That(metals.Items.SequenceEqual(new[] { "silver", "gold", "platinum" }));
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void AddRemove(IAdjustedItemsBuilder builder) {
        var coll = builder.Of(-1);
        coll.Add(Dummies.Sequences.ZeroToEleven).RemoveLast(10).Add(-1);
        Assert.That(coll.Items.SequenceEqual(new[] { -1, 0, 1, -1 }));

        var euroCities = new[] { "Warszawa", "München", "London", "København", "Porto", "Madrid" };

        var foreign = builder.Of("Salut");
        foreign.Add("bonne", "soirée").
            Add(euroCities).
            Remove(x => !x.ToCharArray().Any(sy => sy is (< 'a' or > 'z') and (< 'A' or > 'Z'))).
            Add("Gesundheit");

        Assert.That(foreign.Items.SequenceEqual(new[] { "soirée", "München", "København", "Gesundheit", }), Is.True);
    }

}

public class Mistakes
{
    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public static void OnRemove(IAdjustedItemsBuilder builder) {
        var emptyColl = builder.Of<int>();
        Assert.That(() => emptyColl.RemoveFirst(), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => emptyColl.RemoveLast(), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => emptyColl.RemoveAt(0), Throws.TypeOf<ArgumentOutOfRangeException>());

        var words = builder.Of(Dummies.Text.LoremIpsum.Split());
        var count = words.Items.Count;
        Assert.That(() => words.RemoveFirst(1 + count), Throws.TypeOf<ArgumentException>());
        Assert.That(() => words.RemoveLast(1 + count), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => words.RemoveAt(1, count), Throws.TypeOf<ArgumentException>());

        Assert.That(() => words.RemoveAt(count), Throws.TypeOf<ArgumentOutOfRangeException>());
        Assert.That(() => words.RemoveAt(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}
