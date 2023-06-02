using NUnit.Framework;
using Telerik.JustMock;

namespace Abc.Test.Setup;
public static class TestArgs
{
    public static IEnumerable<TestCaseData> MotleyTypes {
        get {
            yield return new TestCaseData(-7);
            yield return new TestCaseData('c');
            yield return new TestCaseData("dummy string");
            yield return new TestCaseData(double.Epsilon);
            yield return new TestCaseData(DateTime.UnixEpoch);
            yield return new TestCaseData((double r) => 2 * double.Pi * r);

            yield return new TestCaseData(new[] { 3, 5, 7, 11, 13, 17, 19, 23, 29 });

            yield return new TestCaseData(new System.Dynamic.ExpandoObject());
            yield return new TestCaseData(new NotImplementedException("object for test purposes"));
            yield return new TestCaseData(Guid.NewGuid());
        }
    }

    public static IEnumerable<TestCaseData> MultiCodeStrings {
        get {
            yield return new TestCaseData("Dummy");
            yield return new TestCaseData("0123456789");
            yield return new TestCaseData("                    ");
            yield return new TestCaseData(Dummies.Text.AbcEnCaps);
            yield return new TestCaseData("ASCII sample: A1&+,-%777_ascii");

            yield return new TestCaseData("French accent: être après l’appétit Oh là là");
            yield return new TestCaseData("Japanese: どういたしまして ( douitashimashite (welcome) ありがとうございます (arigatou gozaimasu)");
            yield return new TestCaseData("German Umlauds: ßöüaÜÖÄ");
            yield return new TestCaseData("Greek:  Καλημέρα Παρακαλώ Ευχαριστώ");

            yield return new TestCaseData(Dummies.Text.LoremIpsum);
            yield return new TestCaseData(Dummies.Text.PangramEn);
        }
    }

    public static class Numbers
    {
        private const byte caByte = byte.MaxValue / 2;
        private const sbyte sByteZero = 0;
        private const ushort caWord = ushort.MaxValue / 2;
        private const short sWordZero = 0;
        private const ulong caLong = ulong.MaxValue / 2;
        private const long sLongZero = 0;

        private const nint sPointerZero = 0;
        private static readonly nuint caPointer = nuint.MaxValue / 2;

        private const decimal decimalZero = 0;

        public static IEnumerable<TestCaseData> MultiTypeAverages {
            get {
                yield return new TestCaseData(caByte);
                yield return new TestCaseData(sByteZero);
                yield return new TestCaseData(caWord);
                yield return new TestCaseData(sWordZero);
                yield return new TestCaseData(0);
                yield return new TestCaseData(uint.MaxValue / 2);
                yield return new TestCaseData(caLong);
                yield return new TestCaseData(sLongZero);
                yield return new TestCaseData(sPointerZero);
                yield return new TestCaseData(caPointer);

                yield return new TestCaseData(double.Epsilon);
                yield return new TestCaseData(float.Epsilon);
                yield return new TestCaseData(decimalZero);
            }
        }
    }

    public static class Objects_IScenarioToChange
    {
        public static IEnumerable<TestCaseData> Cloneable() {
            yield return new TestCaseData(Mock.Create<ICloneable>());

        }
    }
}