using AbcStruct.Ops.Keyed.Multitype;
using System.Drawing;
using Colors = System.Collections.Generic.IDictionary<string, System.Drawing.Color>;

namespace AbcStructTests.Heaps;
public class ComplexTypesValues
{
    [Test]
    public void Collections() {
        int[] primes = [1, 3, 5, 7, 11, 13, 17, 19, 23]; var origCount = primes.Length;
        var bag = Bag.WithTry.New();

        bag.Put("ints", primes);
        primes = [];
        Assert.That(bag.Could.Read<int[]>("ints", out _), Is.True);
        Assert.That(bag.Could.Read("ints", out primes), Is.True);
        Assert.That(primes, Has.Length.EqualTo(origCount));


        Colors colors = new Dictionary<string, Color> {
            ["info"] = Color.Blue,
            ["warning"] = Color.Yellow,
            ["alarm"] = Color.Red,
        };

        bag.Put(nameof(colors), colors);
        Assert.That(bag.Could.Take<Colors>(nameof(colors), out _), Is.True);
    }

    [Test]
    public void Structures() {
        var bag = Bag.TryOnly.New<sbyte>();

        Assert.That(bag.Put(sbyte.MinValue, Bag.TryOnly.New('A', 1)), Is.True);
        Assert.That(bag.Put(0, Bag.New()), Is.True);
        Assert.That(bag.Put(sbyte.MaxValue, Bag.WithTry.New(1, "one")), Is.True);

        var couldRead = bag.Read<ITryOps<char>>(sbyte.MinValue, out _);
        Assert.That(couldRead, Is.True);

        couldRead = bag.Read<ITryOps<string>>(0, out _);
        Assert.That(couldRead, Is.False);
        couldRead = bag.Take(0, out IDirectOps<string> val);
        Assert.That(couldRead, Is.True);

        couldRead = bag.Take(sbyte.MaxValue, out IWithTryOps<int> primus);
        Assert.That(couldRead, Is.True);
        Assert.That(primus.Read<string>(1), Is.EqualTo("one"));
    }

}
