﻿namespace AbcChrono.Mk.Providers;
class HumanHistory(On scale) : Full<IAnnual>(scale), IHumanEra_wAgo
{
    public new IHumanEra Ago => (IHumanEra)base.Ago;

    public new ICentiMilleDecamille circa() => (ICentiMilleDecamille)base.circa();
    public new ICentiMilleDecamille circa(ushort delta) => (ICentiMilleDecamille)base.circa(delta);
}
