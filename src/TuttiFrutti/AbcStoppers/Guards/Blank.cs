using AbcStoppers.Errors.Data;
using AbcStoppers.Errors.Sys;
using System.Collections;

namespace AbcStoppers.Guards;
public static class Blank
{
    extension(string val)
    {
        public string NoEmpty => val is "" ? Empty.Throw() : val;
        public string NoWhite => val is not "" && string.IsNullOrWhiteSpace(val) ?
            Argument.Throw("whitespace") : val;
    }

    extension<T>(T val)
    {
        public T NoNull => val is null ? NullReference.Throw(val) : val;
    }

    extension(ICollection val)
    {
        public string NoEmpty => val.Count is 0 ? Empty.Throw() : val;
    }
}