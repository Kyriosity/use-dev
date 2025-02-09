namespace Abc.Logic.Build.Disjuncts;
public interface IBlank<Rtrn> : IDisjunction where Rtrn : ITruthValuing
{
    Rtrn EmptyOr { get; }
}
