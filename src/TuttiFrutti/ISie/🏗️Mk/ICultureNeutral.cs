using ISie.Mk.blocks;
using ISie.String.Traits;

namespace ISie.Mk;

public interface ICultureNeutral : LogiOr.INothing<IEndcodingWithGapOption>, IGaps, IStandardTextCode;
