//using Abc.Test.Setup;
//using System.Numerics;

//namespace Abc.Test_Learn.Properties;
//public class AdjustedItemTests
//{
//    [Test, TestCaseSource(typeof(TestArgs), nameof(TestArgs.MotleyTypes))]
//    public void None<T>(T item) {
//        var holder = new Items<T>() { OnSet = x => x };
//        holder.Item = item;

//        Assert.That(item, Is.EqualTo(holder.Item));
//    }

//    [Test, TestCaseSource(typeof(TestArgs), nameof(TestArgs.MultiCodeStrings))]
//    public void Hash(string item) {
//        var holder = new Items<string>() { OnSet = Funcs.HashAnyToAscii };
//        holder.Item = item;

//        Assert.That(holder.Item, Is.Not.EqualTo(item));
//    }

//    [Test, TestCaseSource(typeof(TestArgs.Numbers), nameof(TestArgs.Numbers.MultiTypeAverages))]
//    public void Salt<T>(T item) where T : INumber<T> {
//        var salt = T.CreateChecked(7);
//        var holder = new Items<T>() { OnSet = x => x + salt };
//        holder.Item = item;

//        Assert.That(holder.Item, Is.Not.EqualTo(item));
//    }

//    [Test, TestCaseSource(typeof(TestArgs.Objects_IScenarioToChange), nameof(TestArgs.Objects_IScenarioToChange.Cloneable))]
//    public void Clone<T>(T item) where T : class, ICloneable {
//        var holder = new Items<T> { OnSet = x => (T)x.Clone() };
//        holder.Item = item;
//        Assert.That(ReferenceEquals(item, holder.Item), Is.True);

//        // ToDO: CHANGE A PROP THEN COMPARE
//        var asdasDELETE_MEd = (T)item.Clone();
//        holder = new { OnSet = x => (T)x.Clone() };
//        holder.Item = item;
//        Assert.That(ReferenceEquals(item, holder.Item), Is.False);
//    }

//    //[Test]
//    public void REPLACEWithNew<T>(T item) where T : new() {
//        Items<T> holder = new() { OnSet = x => x };
//        holder.Item = item;
//        Assert.That(item, Is.EqualTo(holder.Item));

//        Func<T, T> onSet = _ => new T();

//        Assert.That(item.Equals(holder.Item), Is.True);
//        //  CHANGE A PROP AND COMPARE
//        Assert.That(item.Equals(holder.Item), Is.False);
//    }

//    // ToDo: TRANSLATE INPUT ? OF CLASS

//    // ToDo: SEQUENCEs
//    // ToDo: WHEN ADJUST FUNC THROWS!
//    // ToDo: ON SET MUST ALWAYS THROW BY DEFAULT !!!!

//    [Test] // ToDO: sort of seqs         SEQ FUNC, STARNUM
//    public void NextSeqNumber() {
//        // FIND NEXt PRIM
//        // BACKCOUNT
//        Items<ulong> sequential = new() { OnSet = x => x };

//        sequential.Item = sequential.Item;
//        //
//    }

//    public void SysOut() {

//        // Length

//        // inch, foot [] STRUCT
//        // Sys.Meter, Sys. cm
//        // DYNO ADJUST !
//        // DEFAULT MASK?  - FULL?

//        // "cast" tests

//        /// .foot    .inch      .IF.foot
//        /// .km     .m    .
//    }

//    struct FootInch<T>
//    {
//        T foot;
//        T inch;
//    }
//}

