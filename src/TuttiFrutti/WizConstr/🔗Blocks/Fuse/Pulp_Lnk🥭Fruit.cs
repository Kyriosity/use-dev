﻿using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse;

public abstract class Pulp_Lnk<T, TRes, Lnk> : basal.rightLnk<T, TRes, Lnk>, ILnkRightOnly
    where Lnk : IBase<TRes>;

public abstract class Fruit_Lnk<T, TRes, Lnk> : Pulp_Lnk<T, TRes, Lnk>
    where Lnk : IBase<TRes>
{
    public static implicit operator TRes(Fruit_Lnk<T, TRes, Lnk> source) => source.Yield();
}