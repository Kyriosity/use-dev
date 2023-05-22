//using Abc.Mk.Coll.Gtor;

//namespace Abc.Coll.Test_Learn._99_SeeMore;
//internal class AdjustInput
//{
//    [Test]
//    public void AdjustAny() {
//        var builder = new AdjustedInputBuilder<ICloneable>(x => (ICloneable)x.Clone());

//        var texts = builder.Of("s");
//        texts = builder.Of<string>();

//        var item = new Item();
//        var objected = builder.Of(item);
//        objected.Add(item);
//        objected.Add(item, item);

//        var items = objected.Items;

//        var crot = new AdjustedInputBuilder<IComparable>(x => x);
//        var primes = crot.Of(1);
//        var log = crot.Of("begin");

//    }

//    public void Numeric() {
//        //var builder = new AdjustedInputBuilder<INumber<long>>(x => x);

//    }

//    public class Item : ICloneable
//    {
//        public int Id = 1;

//        public object Clone() {
//            return new Item { Id = Id + 7 };
//        }
//    }
//}
