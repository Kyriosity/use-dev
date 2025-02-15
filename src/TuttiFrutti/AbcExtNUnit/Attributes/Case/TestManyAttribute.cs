namespace AbcExtNUnit.Attributes.Case;

public class TestManyAttribute : TestCaseSourceAttribute
{
    public TestManyAttribute(params object[] cases) : base(typeof(TestAttribute), nameof(MkSrc), cases) { }

    public TestManyAttribute(object[] caseA, object[] caseB, object[] caseC = null, object[] caseD = null, object[] caseE = null,
        object[] caseF = null, object[] caseG = null, object[] caseH = null, object[] caseI = null, object[] caseJ = null,
        object[] caseK = null, object[] caseL = null, object[] caseM = null, object[] caseN = null, object[] caseO = null,
        object[] caseP = null, object[] caseQ = null, object[] caseR = null, object[] caseS = null, object[] caseT = null,
        object[] caseU = null, object[] caseV = null, object[] caseW = null, object[] caseX = null, object[] caseY = null, object[] caseZ = null)
        : base(typeof(TestAttribute), nameof(MkSrc), []) { }

    public static object[] MkSrc() => [3, -7, 5, -225, 84];

}


