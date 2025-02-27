using ISie.Mk.blocks;
using ISie.String.Traits;

namespace ISie.Mk;

public interface ICultureNeutral : Or.INothing<IEndcodingWithGapOption>, IGaps, IStandardTextCode;
