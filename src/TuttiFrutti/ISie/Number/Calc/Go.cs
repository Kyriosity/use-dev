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

public static partial class MiscForIntegerAndFloat // UNsigned integral types
{
    extension(byte num)
    {
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public uint Square => (uint)(num * num);
        public uint Cube => (uint)(num * num * num);
    }
    extension(ushort num)
    {
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public ulong Square => (ulong)(num * num);
        public ulong Cube => (ulong)(num * num * num);
    }
    extension(uint num)
    {
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;
    }
    extension(ulong num)
    {
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;
    }
}

public static partial class MiscForIntegerAndFloat // floating PT
{
    extension(double num)
    {
        public double Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num); // ToDesign: NaN isn't the best solution -> Guard? NoNaN() + infinite

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public double Square => num * num;
        public double Cube => num * num * num;
    }

    extension(float num)
    {
        public float Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt(num);

        public double Pow(double exponent) => Math.Pow(num, exponent);
        public float Square => num * num;
        public float Cube => num * num * num;
    }

    extension(decimal num)
    {
        public decimal Abs() => Math.Abs(num);
        public double Sqrt() => Math.Sqrt((double)num);

        public double Pow(double exponent) => Math.Pow((double)num, exponent); // ToDo: test if is applicable
        public decimal Square => num * num;
        public decimal Cube => num * num * num;
    }
}