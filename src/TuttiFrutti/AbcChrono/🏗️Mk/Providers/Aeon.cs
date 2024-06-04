namespace AbcChrono.Mk.Providers;
class Aeon(On scale) : Full<IAnnual>(scale), IAeon_wAgo // ToDo: OTHER ANNUAL SETTINGS
{
    public new IAeon Ago => (IAeon)base.Ago;

    public new IMilleCentiThousandsUnlim circa() => (IMilleCentiThousandsUnlim)base.circa();
    public new IMilleCentiThousandsUnlim circa(ushort delta) => (IMilleCentiThousandsUnlim)base.circa(delta);
}
