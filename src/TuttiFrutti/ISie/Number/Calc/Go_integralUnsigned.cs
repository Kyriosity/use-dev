using System;
namespace ISie.Number.Calc;

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

