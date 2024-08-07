namespace AbcStructTests.Heaps;
using System.Drawing;

public class BasicsDemo
{
    [Test]
    public void InstantiateOnly() {
        var bag = Bag.New();
        bag = Bag.New("id", 10223);
        bag = Bag.New<string>();
        // bag = Bag.New<int>(); // won't compile

        var numbered = Bag.TryOnly.New<int>();
        numbered = Bag.TryOnly.New(1, "primus");

        var codeTable = Bag.WithTry.New<char>();
        codeTable.Put('A', new object());

        var timestamped = Bag.New(new DateTime(2002, 1, 1), "C# 1.0 released");
        timestamped.Put(DateTime.Now, "smoke proof");
    }

    [Test]
    public void DirectOps() {
        var bag = Bag.New("canvas", "stochatic");
        bag.Put("background", Color.Aqua);
        bag.Put("rectangle", new Rectangle(new Point(5, 7), new Size(25, 11)));
        bag.Put("point A", new Point(58, 7));
        bag.Put("point B", new Point(11, 199));
        bag.Put("SEAL", true);

        Assert.That(bag.Read<bool>("SEAL"), Is.True);
    }

    [Test]
    public void TriedOps() {
        var sack = Bag.TryOnly.New<int>();

        var idx = 0; var success = false;
        if (sack.Put(++idx, "manifest"))
            if (sack.Put(++idx, Math.PI))
                if (sack.Put(++idx, FileAccess.ReadWrite))
                    if (sack.Put(++idx, () => "lambda sample"))
                        if (sack.Put(++idx, new Camera("Leica")))
                            if (sack.Put(++idx, new Piece("bread", 3)))
                                if (sack.Put(++idx, true)) {
                                    Assert.That(sack.Take(idx, out bool end), Is.True);
                                    Assert.That(end, Is.True);
                                    Assert.That(sack.Take(idx, out bool _), Is.False, $"did Take on {nameof(idx)}={idx}");
                                    success = true;
                                }
        Assert.That(success, Is.True, $"failed on {nameof(idx)}={idx}");
    }

    [Test]
    public void MakeWithTry() {
        var tasks = Bag.WithTry.New<DayOfWeek>();
        tasks.Put(DayOfWeek.Monday, "meeting");
        tasks.Put(DayOfWeek.Tuesday, new Task<string>(() => "begin"));
        tasks.Put(DayOfWeek.Wednesday, new object());
        tasks.Put(DayOfWeek.Thursday, new InvalidProgramException("sys crash"));
        tasks.Put(DayOfWeek.Friday, float.MaxValue);
        tasks.Put(DayOfWeek.Saturday, 'X');

        tasks.Put(DayOfWeek.Sunday, false);
        Assert.That(tasks.Could.Put(DayOfWeek.Sunday, true), Is.False);

        Assert.That(tasks.Could.Take(DayOfWeek.Sunday, out bool isWorkingDay), Is.True);
        Assert.That(isWorkingDay, Is.False);
    }

    [Test]
    public void TakeVsRead() {
        var bag = Bag.WithTry.New(123, "test item");

        for (int i = 0; i < 11; i++)
            _ = bag.Read<string>(123);

        var val = bag.Take<string>(123);
        Assert.That(bag.Could.Read(123, out val), Is.False);
    }

    class Camera(string name) { };
    struct Piece(string name, int num) { };
}
