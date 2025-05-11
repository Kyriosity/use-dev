namespace ISie.Number.Is;
public static class GoIntegral
{
    extension(double num)
    {
        public IIntegralMenu Integer => NotImplemented.Throw("under dev");
    }

    extension(float num)
    {
        public IIntegralMenu Integer => NotImplemented.Throw("under dev");
    }

    extension(decimal num)
    {
        public IIntegralMenu Integer => NotImplemented.Throw("under dev");
    }
}

public interface IIntegralMenu : ISharedMenu
{
    bool Pow2 { get; }
    bool Odd { get; }
}

public interface IFloatMenu : ISharedMenu
{
    IIntegralMenu Integral { get; }
}


// TASK as op for FLOAT NUMS ! + ADD PARALLELISMUS !

public interface ISharedMenu
{

}
