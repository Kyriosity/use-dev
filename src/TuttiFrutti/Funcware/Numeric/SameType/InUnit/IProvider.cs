namespace Funcware.Numeric.SameType.InUnit;
public interface IProvider<in U> : Funcware.Numeric.SameType.IProvider<U>
    where U : Enum
{ }
