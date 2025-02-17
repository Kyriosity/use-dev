namespace AbcExtNUnit.Attributes.Case;

public class ManyAttribute : TestCaseSourceAttribute
{
    public ManyAttribute(params object[] cases) : base(typeof(TestAttribute), nameof(MkArrayOfArrays), cases) { }

    public ManyAttribute(object[] ant, object[] ball, object[] cat = null, object[] dog = null, object[] edge = null, object[] fox = null,
        object[] git = null, object[] hit = null, object[] iron = null, object[] jet = null, object[] kite = null, object[] loot = null,
        object[] mic = null, object[] nut = null, object[] owl = null, object[] pot = null, object[] quo = null, object[] rice = null,
        object[] sky = null, object[] top = null, object[] univ = null, object[] van = null, object[] wit = null,
        object[] xenon = null, object[] yard = null, object[] zoo = null)

        : base(typeof(ManyAttribute), nameof(MkArrayOfArrays), [new object[] { ant, ball, cat, dog, edge, fox, git, hit, iron, jet,
            kite, loot, mic, nut, owl, pot, quo, rice, sky, top, univ, van, wit, xenon, yard, zoo}]) { }

    public static object[]?[] MkArrayOfArrays(object[] args) {
        var supplied = args.TakeWhile(item => item is not null);

        var rows = supplied.Select(x => x as object[]).ToArray();

        return rows;
    }
}


