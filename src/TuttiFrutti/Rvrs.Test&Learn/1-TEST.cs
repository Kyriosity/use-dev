//using Rvrs.Mk;

//namespace Rvrs.Test_Learn;

//// TEST OF SYNTAX

//public class UndoTests
//{
//    [Test, TestCaseSource(nameof(AllBuilders))]
//    public void StepsFromStart(UndoOnly builder) {
//        var item = builder.Of<int>();
//        Assert.That(item.StepsUndo(), Is.EqualTo(0));

//        item = builder.Of(7);
//        Assert.That(item.StepsUndo(), Is.EqualTo(1));

//        //item = builder.Of(1, 2, 3);
//        //Assert.That(item.StepsUndo(), Is.EqualTo(3));

//        //var primes = new int[] { 3, 5, 7, 11, 13, 17, 19, 23, 29 };
//        //item = builder.Of(primes);
//        //Assert.That(item.StepsUndo(), Is.EqualTo(primes.Length));
//    }

//    [Test, TestCaseSource(nameof(AllBuilders))]
//    public void With(UndoOnly builder) {
//        var rvrs = builder.Of(1);
//        Assert.That(rvrs.StepsUndo(), Is.EqualTo(1));
//        var val = rvrs.Value;
//        rvrs.Value += 7;
//        rvrs.Undo();
//        var stepsUndo = rvrs.StepsUndo();

//        val = rvrs.Value;

//        rvrs.Undo();
//        stepsUndo = rvrs.StepsUndo();
//        Assert.That(stepsUndo, Is.EqualTo(0));
//    }

//    public static IEnumerable<TestCaseData> AllBuilders {
//        get {
//            yield return new TestCaseData(new UndoOnly());
//            yield return new TestCaseData(new UndoRedo());
//        }
//    }
//}

