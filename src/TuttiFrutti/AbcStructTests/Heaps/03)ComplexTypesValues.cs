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
        Assert.IsTrue(bag.Could.Read<int[]>("ints", out _));
        Assert.IsTrue(bag.Could.Read("ints", out primes));
        Assert.That(primes.Length, Is.EqualTo(origCount));


        Colors colors = new Dictionary<string, Color> {
            ["info"] = Color.Blue,
            ["warning"] = Color.Yellow,
            ["alarm"] = Color.Red,
        };

        bag.Put(nameof(colors), colors);
        Assert.IsTrue(bag.Could.Take<Colors>(nameof(colors), out _));
    }

    [Test]
    public void Structures() {
        var bag = Bag.TryOnly.New<sbyte>();

        Assert.IsTrue(bag.Put(sbyte.MinValue, Bag.TryOnly.New('A', 1)));
        Assert.IsTrue(bag.Put(0, Bag.New()));
        Assert.IsTrue(bag.Put(sbyte.MaxValue, Bag.WithTry.New(1, "one")));

        var couldRead = bag.Read<ITryOps<char>>(sbyte.MinValue, out _);
        Assert.IsTrue(couldRead);

        couldRead = bag.Read<ITryOps<string>>(0, out _);
        Assert.IsFalse(couldRead);
        couldRead = bag.Take(0, out IDirectOps<string> val);
        Assert.IsTrue(couldRead);

        couldRead = bag.Take(sbyte.MaxValue, out IWithTryOps<int> primus);
        Assert.IsTrue(couldRead);
        Assert.That(primus.Read<string>(1), Is.EqualTo("one"));
    }

}
