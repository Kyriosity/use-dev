using AbcExtNUnit.Attributes.Source;

namespace AbcExtNUnit.Attributes.Case;

public class ManyAttribute : TestCaseSourceAttribute
{
    public ManyAttribute(object item1, object item2, params object[] rest)
        : base(typeof(CasesOutsource), nameof(CasesOutsource.YieldSingle), [item1, item2, rest]) { }

    public ManyAttribute(object[] a0, object[] a1, object[] a2 = null, object[] a3 = null, object[] a4 = null,
        object[] a5 = null, object[] o6 = null, object[] a7 = null, object[] a8 = null, object[] a9 = null,
        object[] b0 = null, object[] b1 = null, object[] b2 = null, object[] b3 = null, object[] b4 = null,
        object[] b5 = null, object[] b6 = null, object[] b7 = null, object[] b8 = null, object[] b9 = null,
        object[] c0 = null, object[] c1 = null, object[] c2 = null, object[] c3 = null, object[] c4 = null,
        object[] c5 = null, object[] c6 = null, object[] c7 = null, object[] c8 = null, object[] c9 = null,
        object[] d0 = null, object[] d1 = null, object[] d2 = null, object[] d3 = null, object[] d4 = null,
        object[] d5 = null, object[] d6 = null, object[] d7 = null, object[] d8 = null, object[] d9 = null,
        object[] e0 = null, object[] e1 = null, object[] e2 = null, object[] e3 = null, object[] e4 = null,
        object[] e5 = null, object[] e6 = null, object[] e7 = null, object[] e8 = null, object[] e9 = null)

        : base(typeof(CasesOutsource), nameof(CasesOutsource.YieldMultiple), [new object[] {
            a0, a1, a2, a3, a4, a5, o6, a7, a8, a9, b0, b1, b2, b3, b4, b5, b6, b7, b8, b9,
            c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, d0, d1, d2, d3, d4, d5, d6, d7, d8, d9,
            e0, e1, e2, e3, e4, e5, e6, e7, e8, e9}]) { }
}
