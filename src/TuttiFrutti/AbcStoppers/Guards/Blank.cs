using AbcStoppers.Errors.Data;
using AbcStoppers.Errors.Sys;
using System.Collections;

namespace AbcStoppers.Guards;
public static class Blank
{
    extension(string val)
    {
        public string NoEmpty(string message = "") => val is "" ? Empty.Throw(message) : val;
    }

    extension<T>(T seed)
    {
        public T NoNull(string message = "") => seed is null ? NullReference.Throw(message) : seed;
    }

    extension(ICollection val)
    {
        public string NoEmpty(string message = "") => val.Count is 0 ? Empty.Throw(message) : val;
    }
}