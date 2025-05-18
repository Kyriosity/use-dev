namespace ISie.Number.Is.Menu.Options;
public interface IFloatPt
{
    bool NaN { get; }
    bool Normal { get; }
    bool Subnormal { get; }
    bool Finite { get; }
    IZeroSide Infinity { get; }
}
