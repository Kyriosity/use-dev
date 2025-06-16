namespace ISie.Number.Calc;
public static partial class MiscForIntegerAndFloat // floating PT and decimal
{
    extension(double num)
    {
        public double Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num); // ToDesign: NaN isn't the best solution -> Guard? NoNaN() + infinite

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;

        public double Truncate() => double.Truncate(num);
    }

    extension(float num)
    {
        public float Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public float Square => num * num;
        public float Cube => num * num * num;

        public float Truncate() => float.Truncate(num);
    }

    extension(decimal num)
    {
        public decimal Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt((double)num);

        public double Pow(double exponent) => Math.Pow((double)num, exponent); // ToDo: test if is applicable
        public decimal Square => num * num;
        public decimal Cube => num * num * num;

        public decimal Truncate() => decimal.Truncate(num);
    }
}
