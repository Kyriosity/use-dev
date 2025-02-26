using AbcDataOps.ISie.Mk.blocks;
using AbcDataOps.Text.Traits;

namespace AbcDataOps.ISie.Mk;

public interface ICultureNeutral : Or.INothing<IEndcodingWithGapOption>, IGaps, IStandardTextCode;
