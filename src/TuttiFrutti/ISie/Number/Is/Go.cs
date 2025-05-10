namespace ISie.Number.Is;
public static class Go
{
    extension(double num)
    {
        public bool Is => double.IsPow2(num);
    }
}
