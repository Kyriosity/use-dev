namespace ISie.Number.Mathe;
public static partial class MiscForIntegerAndFloat // +/- SIGNED integral types
{
    // 🚫 extension<N>(N number) where N : INumber<N> 🚫
    // 1) will apply to char;
    // 2) n/a to unsigned types

    extension(sbyte num)
    {
        public sbyte Abs() => Math.Abs(num);
        public short Pow(sbyte exponent) => (short)Math.Pow(num, exponent); // ToDo: RETHINK pos and negative EXPO
    }

    extension(short num)
    {
        public short Abs() => Math.Abs(num);
        public int Pow(short exponent) => (int)Math.Pow(num, exponent);
    }

    extension(int num)
    {
        public int Abs() => Math.Abs(num);
        public long Pow(int exponent) => (long)Math.Pow(num, exponent);
    }

    extension(long num)
    {
        public long Abs() => Math.Abs(num);
        public double Pow(long exponent) => Math.Pow(num, exponent);
    }

    extension(nint num)
    {
        public nint Abs() => Math.Abs(num);
    }

    extension(BigInteger num)
    {
        public BigInteger Abs() => BigInteger.Abs(num);
        public double Sqrt() => Math.Sqrt((double)num);
    }
}

public static partial class MiscForIntegerAndFloat // UNsigned integral types
{
    extension(byte num)
    {
        public double Sqrt() => Math.Sqrt(num);
    }
    extension(ushort num)
    {
        public double Sqrt() => Math.Sqrt(num);
    }
    extension(uint num)
    {
        public double Sqrt() => Math.Sqrt(num);
    }
    extension(ulong num)
    {
        public double Sqrt() => Math.Sqrt(num);
    }
}


public static partial class MiscForIntegerAndFloat // floating point
{
    extension(double num)
    {
        public double Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num);
    }

    extension(float num)
    {
        public float Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num);
    }

    extension(decimal num)
    {
        public decimal Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt((double)num);
    }
}