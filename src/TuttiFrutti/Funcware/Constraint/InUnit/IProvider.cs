namespace Funcware.Constraint.InUnit;
public interface IProvider<U, C> : Constraint.IProvider<U, C>
    where U : Enum
{ }
