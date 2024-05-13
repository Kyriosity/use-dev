namespace AbcChrono.Mk.Providers;
class Aeon : Full, IAeon_wAgo
{
    public new IAeon Ago => (IAeon)base.Ago;

    public new IMilleCentiThousandsUnlim circa() => (IMilleCentiThousandsUnlim)base.circa();
    public new IMilleCentiThousandsUnlim circa(ushort delta) => (IMilleCentiThousandsUnlim)base.circa(delta);
}
