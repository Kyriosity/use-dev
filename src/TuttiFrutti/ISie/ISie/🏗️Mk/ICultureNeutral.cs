using ISie.Mk.blocks;
using ISie.Text.Traits;

namespace ISie.Mk;

public interface ICultureNeutral : Or.INothing<IEndcodingWithGapOption>, IGaps, IStandardTextCode;
