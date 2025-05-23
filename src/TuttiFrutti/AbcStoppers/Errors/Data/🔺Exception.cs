﻿using AbcRefl.Stack;

namespace AbcStoppers.Errors.Data;

public abstract class Exception<Exc>(string message) : Basal.Exception<Exc>(message)
    where Exc : Exception
{
    public static dynamic Throw() => Throw(Caller.Digest);
}
