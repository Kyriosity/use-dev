namespace AbcChrono.Mk.Providers;

class GeoAges : Full, IGeoAges_wAgo
{
    public new IGeoAges Ago => (IGeoAges)base.Ago;

    public new IMilleTenThousandsPlus circa() => (IMilleTenThousandsPlus)base.circa();
    public new IMilleTenThousandsPlus circa(ushort delta) => (IMilleTenThousandsPlus)base.circa(delta);
}
