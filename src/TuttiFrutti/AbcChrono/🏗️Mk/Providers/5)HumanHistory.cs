namespace AbcChrono.Mk.Providers;
class HumanHistory(Scale scale) : Full(scale), IHumanEra_wAgo
{
    public new IHumanEra Ago => (IHumanEra)base.Ago;

    public new ICentiMilleDecamille circa() => (ICentiMilleDecamille)base.circa();
    public new ICentiMilleDecamille circa(ushort delta) => (ICentiMilleDecamille)base.circa(delta);
}
