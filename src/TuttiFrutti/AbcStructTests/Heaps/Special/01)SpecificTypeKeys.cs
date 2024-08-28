using System.Globalization;

namespace AbcStructTests.Heaps.Special;
public class SpecificValuesId
{
    [Test]
    public void NullableValues() {

        var cult = CultureInfo.CurrentCulture;

        var rtv = typeof(string).Assembly.ImageRuntimeVersion;
        var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        const string Id = "NullId";
        var bag = Bag.New();

        bag.Put(Id, true);
        bag.Put<bool?>(Id, null);
        Assert.That(bag.Read<bool>(Id), Is.True);
        Assert.That(bag.Read<bool?>(Id), Is.Null);

        bag.Put<int?>(Id, null);
        // bag.Put<int>(Id, null); // won't compile
        Assert.Throws<EntityNotFound>(() => bag.Take<int>(Id));
        Assert.That(bag.Take<int?>(Id), Is.Null);

        bag.Put<object>(Id, null);
        Assert.That(bag.Take<object>(Id), Is.Null);

        bag.Put<string?>(Id, "can but isn't null");
        Assert.That(bag.Take<string?>(Id), Is.Not.Null);

        bag.Put<string>(Id, null);
        Assert.That(bag.Take<string>(Id), Is.Null);
    }

    [Test]
    public void ObjectCasting() {
        Assert.Ignore("implement on demand");
    }

    public void TUPLE2MOVE() {
        // SEE BELOW -> PLUS OTHER OPs apply like ==

    }

}

public struct Point
{
    public Point(double x, double y) =>
        (_x, _y, _distance) = (x, y, default);

    public double X {
        readonly get => _x;
        private set => _x = value;
    }
    private double _x;

    public double Y {
        get => _y;
        private set => _y = value;
    }
    private double _y;


    private double? _distance;
    public double Distance {
        get {
            if (!_distance.HasValue)
                _distance = Math.Sqrt((X * X) + (Y * Y));
            return _distance.Value;
        }
    }

    public void Swap() => (X, Y) = (Y, X);
}
