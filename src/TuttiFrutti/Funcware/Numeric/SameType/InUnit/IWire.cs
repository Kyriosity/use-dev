namespace Funcware.Numeric.SameType.InUnit;

public interface IWire<in U> : Funcware.Numeric.SameType.IWire<U> where U : Enum;
