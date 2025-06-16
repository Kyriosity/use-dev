namespace ISie.Number.Calc;

public static partial class MiscForIntegerAndFloat // +/- SIGNED integral types
{
    // 🚫 extension<N>(N number) where N : INumber<N> 🚫
    // 1) will apply to char;
    // 2) n/a to unsigned types

    extension(sbyte num)
    {
        public sbyte Abs() => Math.Abs(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public int Square => num * num;
        public int Cube => num * num * num;
    }

    extension(short num)
    {
        public short Abs() => Math.Abs(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public long Square => num * num;
        public long Cube => num * num * num;
    }

    extension(int num)
    {
        public int Abs() => Math.Abs(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;
    }

    extension(long num)
    {
        public long Abs() => Math.Abs(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;
    }

    extension(nint num)
    {
        // 🚫 public nint Abs() => Math.Abs(num); // specific pointer type
    }

    extension(BigInteger num)
    {
        public BigInteger Abs() => BigInteger.Abs(num);
        public double Sqrt() => Math.Sqrt((double)num);
    }
}
