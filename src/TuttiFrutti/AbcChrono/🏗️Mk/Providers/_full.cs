using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Providers;

class Full : YearsX1_000_000_000, IApproximate<YearsX1_000_000_000, ushort>
{
    public Full() : base("ERA") { }

    public YearsX1_000_000_000 circa() => circa(1);

    public YearsX1_000_000_000 circa(ushort delta = 1) {
        Model = $"( ca+/-{delta})";
        return this;
    }

    public Full Ago {
        get {
            Model = $"AGO";
            return this;
        }
    }

    public IMonths_wShortcuts_wCa At { get; } = new Calendar_wShortcuts_wCa();
}
