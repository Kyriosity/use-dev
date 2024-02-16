namespace Funcware.Constraint.InUnit;

public interface IWire<in U, in C> : Funcware.Constraint.IWire<U, C> where U : Enum;
