namespace Funcware.Constraint.InUnit;

public interface IWire<in U, in C> : Constraint.IWire<U, C> where U : Enum;
