namespace Funcware.Numeric.SameType.InUnit;
public interface IWire<in U> : SameType.IWire<U> where U : Enum;
